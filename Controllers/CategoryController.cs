using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code2Night.DAL.Common;
using Code2Night.DAL.Interfaces;
using Code2Night.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Code2Night.Controllers
{
    public class CategoryController : Controller
    {
        private ITutorial _tutorial;

        public CategoryController(ITutorial tutorial)
        {
            _tutorial = tutorial;
        }

        public IActionResult Index()
        {
            var list = _tutorial.GetCategories();
            return View(list);
        }

        [HttpPost]
        public JsonResult InsertCategory(Category category)
        {
            var insertCate = _tutorial.InsertCategory(category);
            return Json(insertCate);
        }

        [HttpPost]
        public ActionResult SaveTopic(AritcleViewModel model, IFormFile documents)
        {
            if (documents?.Length > 0 && documents.FileName != "")
            {
                model.TopicDetail.Image = FileUploads.SaveFile(documents, CurrentDirectoryHelpers.GetServerPath() + "/Uploads/Topic");
            }

           _tutorial.InsertTopic(model.TopicDetail);
            return RedirectToAction("Topics");
        }

        public ActionResult Delete(int id)
        {
            Connection.Delete(id,"sprCategory","Delete");
            return RedirectToAction("Index");
        }

        public ActionResult DeleteTopic(int id)
        {
            Connection.Delete(id, "sprTopic", "Delete");
            return RedirectToAction("Topics");
        }

        public IActionResult Topics()
        {
            var list = _tutorial.GetCategories();
            var model = new AritcleViewModel
            {
                GetCategories=list,
                GetTopics=_tutorial.GetTopics(),
                TopicDetail=new Topics()
            };
            return View(model);
        }

    } 
}
