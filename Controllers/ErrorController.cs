using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Code2Night.Controllers
{
    public class ErrorController : Controller
    {
        // GET: Error
        public IActionResult index()
        {
            return View();
        }
    }
}