using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Filters.Action;
using MSpace.Filters.Authorization;

namespace MSpace.Controllers
{
    [LoginStatus]
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        [ExecutionTiming]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.AuthorName = "常伟华";
            return View();
        }

        public ActionResult RSS()
        {
            return View();
        }

        public ActionResult Gallary()
        {
            return View();
        }

        public ActionResult Gallary2()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Album()
        {
            return View();
        }

    }
}
