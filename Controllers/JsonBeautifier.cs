﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Code2Night.Controllers
{
    public class JsonBeautifier : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}