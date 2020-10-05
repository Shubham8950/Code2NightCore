using Code2Night.DAL.Common;
using Code2Night.DAL.Interfaces;
using Code2Night.DAL.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Security.Application;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Code2Night.Controllers
{
    public class BlogController : BaseController
    {
        private  IBlog _blogrepo;
        private  IUserRepo _userrepo;
        IHttpContextAccessor httpContextAccessor;

        public BlogController(IBlog blogrepo, IUserRepo userRepo,IHttpContextAccessor context):base(new UserRepo(),new BlogRepo())
        {
            _blogrepo = blogrepo;
            _userrepo = userRepo;
            httpContextAccessor = context;
        }

        public IActionResult Index()
        {
            var blog = new MyBlogs
            {
                BlogsList = _blogrepo.GetFilterBlog(1, 3, "", false).ToList()
            };
            return View("index", blog);
        }

        public Microsoft.AspNetCore.Mvc.ActionResult BindBlogs()
        {
            var blog = new MyBlogs
            {
                BlogsList = _blogrepo.GetFilterBlog(1,3,"",false).ToList()
            };
            return PartialView("_BlogsList", blog);
        }

        [HttpPost]
        public ActionResult FilterBlog(int? pageNumber,string search,bool IsFilter)
        {
            var model = new MyBlogs
            {
                BlogsList = _blogrepo.GetFilterBlog(pageNumber , 3, search,true).ToList()
            };
            return PartialView("_BlogsList", model);
        }

        [AuthenticateUser]
        [EncryptedActionParameterAttribute]
        public IActionResult EditBlog(int? Id)
        {
            if (Id != null && Id > 0)
            {
                var blog = _blogrepo.GetBlogsById(Convert.ToInt32(Id));
                var body = "";
                using (StreamReader reader = new StreamReader(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blog.Id + ".txt"))
                {
                    body = reader.ReadToEnd();
                }
                blog.BlogBody = body;
                return View("AddBlog",blog);
            }
            else
            {
                return View("AddBlog",new Blog());
            }
        }

        [AuthenticateUser]
        public IActionResult AddBlog()
        {
           return View(new Blog());
        }

        [HttpPost]
        public JsonResult AddBlog(Blog blog, IFormFile documents)
        {
            var file = "";
            if (documents?.Length > 0 && documents.FileName != "")
            {
                file = FileUploads.SaveFile(documents, CurrentDirectoryHelpers.GetServerPath() + "/Uploads/BlogDocs");
            }
            string textfile = blog.BlogBody;

            var user = _userrepo.GetUserByUserId(Convert.ToInt32(this.GetUserIdCookieValue()));
            string Blogurl = Sanitizer.GetSafeHtmlFragment(blog.Title).Trim().Replace(' ', '-').Replace(".", "");
            if (blog.Tags != null)
            {
                var items = blog.Tags.Split(',');
                var NewListItems = new List<string>();
                foreach (var item in items)
                {
                    NewListItems.Add(item.Trim().Replace(".", "").Replace(" ","-"));
                }
                blog.Tags = string.Join(",", NewListItems);
            }
            var myblog = new Blog()
            {
                Title = blog.Title,
                Tags = blog.Tags,
                BlogBody = blog.BlogBody,
                Date = DateTime.Now,
                User = new Users() { Name = user.Name, Email = user.Email, Id = user.UserID },
                BlogUrl = Blogurl,
                BlogMonth = DateTime.Now.ToString("MMM-yyyy"),
                VideoEmbed = blog.VideoEmbed,
                AuthorId = Convert.ToString(user.UserID),
                BlogIntroduction = blog.BlogIntroduction,
                Id=blog.Id,
                Document = file
            };
            var id = _blogrepo.AddBlog(myblog);
            if (blog.Id>0)
            {
                if (System.IO.File.Exists(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blog.Id + ".txt"))
                {
                    string fullPath = CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blog.Id + ".txt";
                    using (StreamWriter writer = new StreamWriter(fullPath, false))
                    {
                        writer.WriteLine(textfile);
                    }
                }
                else
                {
                    string fullPath = CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blog.Id + ".txt";
                    using (StreamWriter writer = new StreamWriter(fullPath))
                    {
                        writer.WriteLine(textfile);
                    }
                }
            }
            else
            {
               string fullPath = CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + id + ".txt";
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    writer.WriteLine(textfile);
                }
            }
            CreateSiteMaps();
            return Json(new { Success = true });
        }

        [HttpPost]
        public IActionResult UploadFile(IFormFile aUploadedFile)
        {
            var vReturnImagePath = string.Empty;
            if (aUploadedFile.Length > 0)
            {
                var vFileName = Path.GetFileNameWithoutExtension(aUploadedFile.FileName);
                var vExtension = Path.GetExtension(aUploadedFile.FileName);

                string sImageName = vFileName + DateTime.Now.ToString("yyyyMMddhhmmss");

                var vImageSavePath = CurrentDirectoryHelpers.GetServerPath() + "/Uploads/" + sImageName + vExtension;
                vReturnImagePath = "/Uploads/" + sImageName + vExtension;
                var path = vImageSavePath;
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    aUploadedFile.CopyTo(stream);
                }
            }
            return Json(Convert.ToString(vReturnImagePath));
        }
        public IActionResult Logout()
        {
             Encrypt.CloseUserSession(httpContextAccessor.HttpContext);
            return RedirectToAction("Login", "Users");
        }

        [AuthenticateUser]
        public IActionResult MyBlogs()
        {
            var user = _userrepo.GetUserByUserId(Convert.ToInt32(this.GetUserIdCookieValue()));
            var myblogs = _blogrepo.GetMyBlogs(user);
            foreach (var blog in myblogs)
            {
                var body = "";
                if(System.IO.File.Exists(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blog.Id + ".txt"))
                {
                    using (StreamReader reader = new StreamReader(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blog.Id + ".txt"))
                    {
                        body = reader.ReadToEnd();
                    }
                }
                
                blog.BlogBody = body;
            }
            return View(myblogs);
        }

        public IActionResult MyBlog(string id)
        {
            string body = string.Empty;
            var blog = new MyBlogs
            {
                BlogsList = _blogrepo.GetBlogs()
            };
            blog.MyBlog = _blogrepo.BlogDetail(id);
            using (StreamReader reader = new StreamReader(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blog.MyBlog.Id + ".txt"))
            {
                body = reader.ReadToEnd();
            }
            blog.MyBlog.BlogBody = body;

            return View("BlogDetail", blog);
        }

        public IActionResult Tags(string id)
        {
            var blog = new MyBlogs
            {
                BlogsList = _blogrepo.GetBlogs().Where(x => x.Tags!=null && x.Tags.Contains(id, StringComparison.OrdinalIgnoreCase)).ToList(),
                Tag = Sanitizer.GetSafeHtmlFragment(id)
            };
            foreach (var blogDetail in blog.BlogsList)
            {
                string body = "";
                using (StreamReader reader = new StreamReader(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blogDetail.Id + ".txt"))
                {
                    body = reader.ReadToEnd();
                }
                blogDetail.BlogBody = body;
            }
            return View("Tags", blog);
        }

        public IActionResult TagsList()
        {
            var blog = new MyBlogs
            {
                Tags = string.Join(",", _blogrepo.Tag().Select(x => x.Tags)).Split(',').ToList()
            };
            return PartialView("_Tags", blog);
        }

        
        public IActionResult Author(string id)
        {
            var blog = new MyBlogs
            {
                BlogsList = _blogrepo.GetBlogs().Where(x => x.AuthorId.Contains(id.Split('-').First())).ToList(),
                Author = id.Split('-').Last()
            };
            foreach (var blogDetail in blog.BlogsList)
            {
                string body = "";
                using (StreamReader reader = new StreamReader(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blogDetail.Id + ".txt"))
                {
                    body = reader.ReadToEnd();
                }
                blogDetail.BlogBody = body;
            }
            return View("Tags", blog);
        }

        [AdminAuthenticateUser]
        public IActionResult Listing()
        {
            var GetBlogs = _blogrepo.GetBlogs();
            foreach (var blogDetail in GetBlogs)
            {
                string body = "";
                using (StreamReader reader = new StreamReader(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + blogDetail.Id + ".txt"))
                {
                    body = reader.ReadToEnd();
                }
                blogDetail.BlogBody = body;
            }
            return View(GetBlogs);
        }

        [HttpGet]
        public IActionResult Delete(int Blogid)
        {
            _blogrepo.BlogDelete(Blogid);
            return RedirectToAction("Listing");
        }
    }
}