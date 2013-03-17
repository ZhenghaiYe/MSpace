using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class ArticleController : AdminBaseController
    {
        //
        // GET: /Admin/Article/

        private ArticleRepository repository = new ArticleRepository();
        private ArticleCategoryRepository acRepository = new ArticleCategoryRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var query = repository.List();

            return Json(query, JsonRequestBehavior.AllowGet);
        }

        public ActionResult RelatedArticle()
        {
            
            return PartialView();
        }

        public ActionResult Detail(int id = 0)
        {
            var model = repository.Find(id);

            if (model == null)
            {
                return View("Index");
            }

            return View("Write", model);
        }

        public ActionResult Write()
        {
            var list =acRepository.List().OrderBy(_ => _.Id).ToList();
            ViewBag.ArticleCategories = new SelectList(list, "Id", "CategoryName");
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Write(Article article)
        {
           var a = TryValidateModel(article);

            NLog.LogManager.GetCurrentClassLogger().Debug("是否通过====" + a);

            if (ModelState.IsValid)
            {
                article.PubDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                var flag = repository.Add(article);
                HandlerResult result = null;
                if (flag)
                {
                    result = new HandlerResult { IsSuccess = true, Message="操作成功" };
                }
                else
                {
                    result = new HandlerResult { IsSuccess = false, Message = "操作失败" };
                }
                return View("Index");
            }
            return View(article);
        }

    }
}
