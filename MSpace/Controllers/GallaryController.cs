using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Controllers
{
    public class GallaryController : Controller
    {
        //
        // GET: /Gallary/

        private AlbumImageRepository albumImageRepository = new AlbumImageRepository();

        public ActionResult Index()
        {
            ViewBag.PageIndex = 2;
            return View("Water2");
        }

        public ActionResult Water()
        {
            ViewBag.PageIndex = 2;
            return View();
        }

        public ActionResult Water2()
        {
            ViewBag.PageIndex = 2;
            return View();
        }


        public ActionResult WaterFall()
        {
            return View();
        }

        public ActionResult Page(int id)
        {
            var list = albumImageRepository.List();
            //var pageIndex = ++id;
            //return Json(list, JsonRequestBehavior.AllowGet);
            ViewBag.PageIndex = ++id;

            StringBuilder sb = new StringBuilder();

            foreach (AlbumImage item in list)
            {
                sb.AppendFormat("<div class=\"item\"><img src=\"{0}\"/>{1}</div>", item.Url, item.OriginName); 
            }

            return Content(sb.ToString());
            //return Content("<div class=\"item\"><img src='http://localhost:32065/Images/图像 057.png'/></div><div class=\"item\"><img src='http://localhost:32065/Images/图像 057.png'/></div><div class=\"item\"><img src='http://localhost:32065/Images/图像 057.png'/></div><div class=\"item\"><img src='http://localhost:32065/Images/图像 057.png'/></div><div class=\"item\"><img src='http://localhost:32065/Images/图像 057.png'/></div><div class=\"item\"><img src='http://localhost:32065/Images/图像 057.png'/></div>");
        }

    }
}
