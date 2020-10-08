using Code2Night.Controllers;
using Code2Night.DAL.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Code2Night.Areas.Admin.Controllers
{
    [AdminAuthenticateUser]
    public class DashboardController : BaseController
    {
        public DashboardController() : base(new BlogRepo())
        {
        }
        public IActionResult Home()
        {
            return View();
        }
    }
}