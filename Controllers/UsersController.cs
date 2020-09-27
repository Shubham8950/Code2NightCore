using Code2Night.DAL.Common;
using Code2Night.DAL.Interfaces;
using Code2Night.DAL.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Code2Night.Controllers
{
    public class UsersController : BaseController
    {
        private IUserRepo _userrepo;
        HomeViewModel home = new HomeViewModel();

        public UsersController(IUserRepo userrepo):base(new UserRepo(),new BlogRepo())
        {
            _userrepo = userrepo;
        }

        public IActionResult Index()
        {
            var list = _userrepo.GetUsers();
            return View(home);
        }

        public IActionResult Login()
        {
            if (GetUserCookieValue("UserId") != null && !string.IsNullOrEmpty(GetUserCookieValue("UserId")) && GetUserCookieValue("UserId") != "0")
            {
                if (GetUserCookieValue("Role") == "Admin")
                {
                    return RedirectToAction("index", "DashboardGraph");
                }
                else
                {
                    return RedirectToAction("index", "Users");
                }
            }
            else
            {
                CloseUserSession();
            }
            return View();
        }
        public void CloseUserSession()
        {
            var cookies = Request.Cookies["UserId"];
            if (cookies != null)
            {
                CookieOptions option = new CookieOptions
                {
                    Expires = DateTime.Now.AddDays(-1)
                };
                Response.Cookies.Append("UserId", "", option);
            }

           // HttpContext.Session.Clear();
        }
        public ActionResult SqlServerTutorial()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            var list = _userrepo.GetExistingUserNames();
            return View(list);
        }

        public ActionResult ContactUs()
        {
            return View();
        }

        [HttpGet]
        public ActionResult VerifyAccount(Guid Id)
        {
            ViewBag.Activated = _userrepo.ActivateAccount(Id);
            return View();
        }

        [HttpPost]
        public JsonResult ResendVerificationMail(string Email)
        {
            var result = _userrepo.ResendVerificationMail(Email);
            return Json(result);
        }

        [HttpPost]
        public JsonResult UserFetch(string Name)
        {
            var list = _userrepo.GetExistingUserNames();
            return Json(list.Contains(Name));
        }

        public ActionResult Blog(string id)
        {
             return View();
        }

        [HttpPost]
        public IActionResult Login(string UserName, string Password, bool Remember)
        {
            var user = _userrepo.UserLogin(UserName, Password);
            if (user.Username == null || !user.IsActive)
            {
                return Json(new string[] { "0", user.IsActive && user.Username == null ? "Incorrect UserName or Password":"Your account is not active .Please click on Activation link in mail sent on your registered email."});
            }
            else
            {
                SaveUserCookies(user);
                return Json(new string[] { "1", user.UserRole });
            }
        }

        [HttpPost]
        public PartialViewResult SuccessFulRegistration()
        {
             return PartialView("~/Views/Shared/_SuccessfulRegistration.cshtml");
        }

        [HttpPost]
        public JsonResult Registerations(string Name, string Email, string Contact, string Username, string Password)
        {
            Users user = new Users()
            {
                Username = Username,
                Email = Email,
                ContactNo = Contact,
                Password = Password,
                Name = Name,
                UserRole = "Author",
                IsActive = false
            };
            int i = _userrepo.AddNewAccount(user);
            return Json(i);
        }

        [AdminAuthenticateUser]
        public ActionResult UserLists()
        {
            var getusr = _userrepo.GetUsers();
            return View(getusr);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            _userrepo.UserDelete(id);
            return RedirectToAction("UserLists");
        }
    }
}