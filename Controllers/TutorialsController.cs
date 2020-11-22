using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Code2Night.DAL.Common;
using Code2Night.DAL.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code2Night.Controllers
{
    public class TutorialsController : Controller
    {
        private ITutorial _tutorial;


        public TutorialsController(ITutorial tutorial)
        {
            _tutorial = tutorial;
        }

        public IActionResult Index()
        {
            var getAllTutorial = _tutorial.TutorialsList();
            return View(getAllTutorial);
        }

        public IActionResult Article(string id)
        {
            var getAllTutorial = _tutorial.ArticleList(id);
            return View(getAllTutorial);
        }

        public IActionResult ArticleDetail(int id)
        {
            var getArticle = _tutorial.Article(id);
            using (StreamReader reader = new StreamReader(CurrentDirectoryHelpers.GetServerPath() + "/BlogFiles/Blog_" + getArticle.BlogId + ".txt"))
            {
                getArticle.ArticleBody = reader.ReadToEnd();
            }
            return PartialView("_Article", getArticle);
        }
    }
}
