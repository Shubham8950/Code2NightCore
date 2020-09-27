using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Facebook;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Code2Night.Controllers
{
    public class FacebookLoginController : Controller
    {
        // GET: FacebookLogin
        public IActionResult Index()
        {
            return View();
        }
        public string Facebook_GraphAPI_Token = "https://graph.facebook.com/oauth/access_token?";
        public string Facebook_GraphAPI_Me = "https://graph.facebook.com/me?";
        public string AppID = "417969189179630";
        public string AppSecret = "06c17c2f93a765092cc12114d146f4c5";


        private Uri RedirectUri
        {
            get
            {
                var uriBuilder = new UriBuilder(Request.Url);
                uriBuilder.Query = null;
                uriBuilder.Fragment = null;
                uriBuilder.Path = Url.Action("FacebookCallback");
                return uriBuilder.Uri;
            }
        }

        [AllowAnonymous]
        public ActionResult login()
        {
            return View();
        }

        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return View("Login");
        }

        [AllowAnonymous]
        public ActionResult Facebook()
        {
            var fb = new FacebookClient();
            var loginUrl = fb.GetLoginUrl(new
            {
                client_id = "417969189179630",
                client_secret = "06c17c2f93a765092cc12114d146f4c5",
                redirect_uri = RedirectUri.AbsoluteUri,
                response_type = "code",
                scope = "email" // Add other permissions as needed
            });

            return Redirect(loginUrl.AbsoluteUri);
        }

        public IActionResult FacebookCallback(string code)
        {
            var fb = new FacebookClient();
            dynamic result = fb.Post("oauth/access_token", new
            {
                client_id = "417969189179630",
                client_secret = "06c17c2f93a765092cc12114d146f4c5",
                redirect_uri = RedirectUri.AbsoluteUri,
                code = code
            });

            var accessToken = result.access_token;

            // Store the access token in the session for farther use
            //Session["AccessToken"] = accessToken;

            // update the facebook client with the access token so 
            // we can make requests on behalf of the user
            fb.AccessToken = accessToken;

            // Get the user's information
            dynamic me = fb.Get("me?fields=first_name,middle_name,last_name,id,email,name");
            string email = me.email;
            string firstname = me.first_name;
            string middlename = me.middle_name;
            string lastname = me.last_name;
            string id = me.id;
            string fullname = me.name;
            // Set the auth cookie
            //FormsAuthentication.SetAuthCookie(email, false);
            return RedirectToAction("Index", "Home");
        }
    }
}