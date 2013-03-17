using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class RssController : AdminBaseController
    {
        //
        // GET: /Admin/Rss/
        private RssSourceRepository repository = new RssSourceRepository();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RssSource rssSource)
        {
            if (ControllerContext.HttpContext.Request.IsAjaxRequest())
            {
                if (ModelState.IsValid)
                {
                    repository.Add(rssSource);
                    var result = new HandlerResult { IsSuccess = true, Message = "添加RSS源成功" };
                    return Json(result);
                }
                else
                {
                    var result = new HandlerResult { IsSuccess = false, Message = "添加RSS源失败" };
                    return Json(result);
                }
            }
            else
            {
                if (ModelState.IsValid)
                {
                    var flag = repository.Add(rssSource);
                    return Redirect("Index");
                }
                else
                {
                    return View(rssSource);
                }
            }
        }

        public ActionResult Load(string url)
        {
            XDocument doc = XDocument.Load(url);

            var query = doc.Descendants("item").Take(15);
            List<RssEntity> entities = new List<RssEntity>();
            foreach (var item in query)
            {
                entities.Add(new RssEntity
                {
                    Guid = item.Element("guid").Value,
                    Author = "",
                    Link = item.Element("link").Value,
                    PubDate = item.Element("pubDate").Value,
                    Description = item.Element("description").Value,
                    Title = item.Element("title").Value
                });
            }

            return Json(entities, JsonRequestBehavior.AllowGet);

        }

        public ActionResult List()
        {
            if (ControllerContext.HttpContext.Request.IsAjaxRequest())
            {
                var list = repository.List();

                return Json(list, JsonRequestBehavior.AllowGet);
            }
            return View();

        }

        public ActionResult Edit(int id)
        {
            var list = repository.List();

            return View();
        }

    }
}
