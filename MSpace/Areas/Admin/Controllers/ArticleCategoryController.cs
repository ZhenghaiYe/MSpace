using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class ArticleCategoryController : AdminBaseController
    {
        //
        // GET: /Admin/Category/

        private ArticleCategoryRepository repository;

        public ActionResult Index(int id = 2)
        {
            ViewBag.SectionId = id;
            if (id == 3)
            {
                repository = new ArticleCategoryRepository();
                var list =repository.List().OrderBy(_ => _.Id).ToList();
                list.Insert(0, new ArticleCategory { Id = 0, CategoryName = "顶级分类" });
                ViewBag.Categories = new SelectList(list, "Id", "CategoryName");
            }
            
            return View();
        }

        public ActionResult List() 
        {
            repository = new ArticleCategoryRepository();

            var query = repository.List();

            return Json(query, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Add(ArticleCategory category)
        {
            if (ModelState.IsValid) 
            {
                repository = new ArticleCategoryRepository();
                repository.Add(category);
                ViewBag.SectionId = 2;
                return RedirectToAction("Index");
            }
            ViewBag.SectionId = 3;
            
            return View("Index", category);
        }

        [HttpPost]
        public ActionResult Remove(int id)
        {
            repository = new ArticleCategoryRepository();
            var flag = repository.Delete(id);
            return Json(flag);
        }

        public ActionResult Edit(int id)
        {
            repository = new ArticleCategoryRepository();
            var category = repository.Find(id);
            if (category == null)
            {
                ViewBag.SectionId = 2;
                return View("Index");
            }
            var list = repository.List().Where(_ => _.Id != id).OrderBy(_ => _.Id).ToList();
            list.Insert(0, new ArticleCategory { Id = 0, CategoryName = "顶级分类" });
            ViewBag.Categories = new SelectList(list, "Id", "CategoryName");
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(ArticleCategory category)
        {
            //TryValidateModel(category);
            if (ModelState.IsValid)
            {
                repository = new ArticleCategoryRepository();
                //var _ = repository.Find(category.Id);
                //_.Id = category.Id;
                //_.ParentId = category.ParentId;
                //_.LinkName = category.LinkName;
                //_.LinkUrl = category.LinkUrl;
                //_.SortOrder = category.SortOrder;
                //_.Status = category.Status;
                //repository.Update(_);
                repository.Update(category);
                ViewBag.SectionId = 2;
                return RedirectToAction("Index");
            }
            ViewBag.SectionId = 4;
            return View("Index", category);
        }

    }
}
