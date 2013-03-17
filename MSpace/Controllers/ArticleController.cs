using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Controllers
{
    public class ArticleController : Controller
    {
        //
        // GET: /Article/
        private ArticleRepository repository = new ArticleRepository();

        private int size = 6;

        public ActionResult Index(int id = 0)
        {
            var list = repository.List(id * size, size);
            var flag = repository.List((id + 1) * size, size).OfType<Article>().Count() > 0;

            ViewBag.Next = flag ? id + 1 : -1;
            ViewBag.Prev = id - 1 < 0 ? -1 : id - 1;
            return View(list);
        }

        public ActionResult AjaxIndex()
        {
            return View();
        }

        public ActionResult RelatedArticle(string id)
        {
            ViewBag.Tag = id;
            var list = repository.List().OfType<Article>().ToList().FindAll(_ => _.ArticleTag.ToLower().Contains(id.ToLower()));
            ViewBag.Articles = list.Count >= 5 ? list.Take(5) : list;
            return PartialView();
        }

        /// <summary>
        /// 相关日志
        /// </summary>
        /// <param name="id">标签</param>
        /// <returns></returns>
        public ActionResult Related(string id)
        {
            ViewBag.Tag = id;
            var list = repository.List().Where(_ => _.ArticleTag.Contains(id)).ToList().Select((a, index) => new { id = a.Id, title = a.Title, summary = a.Summary });
            return Json(new { tag = id, articles = list }, JsonRequestBehavior.AllowGet);
        } 

        public ActionResult List()
        {
            var list = repository.List();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Page(int id)
        {
            var list = repository.List(id * size, size);
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Read(int id)
        {
            ViewBag.Id = id;
           
            var prevList = from a in repository.List().OfType<Article>() where a.Id < id select new { Id = a.Id };
            ViewBag.Prev = prevList.OrderBy(_ => _.Id).ToList().Count>0 ? prevList.OrderBy(_ => _.Id).ToList().Last().Id : -1;

            var nextList = from a in repository.List().OfType<Article>() where a.Id > id select new { Id = a.Id };
            ViewBag.Next = nextList.OrderBy(_ => _.Id).ToList().Count > 0 ? nextList.OrderBy(_ => _.Id).ToList().First().Id : -1;

            Article article = repository.Find(id);
            return View(article);
        }

        public ActionResult Comment()
        {
            return PartialView();
        }

    }
}
