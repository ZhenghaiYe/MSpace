using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Controllers
{
    public class CareerController : Controller
    {
        //
        // GET: /Career/

        public ActionResult Index()
        {
            return View("Resume");
        }

        public ActionResult Resume()
        {
            return View();
        }

        public ActionResult Experience()
        {
            return View();
        }

        public ActionResult Plan()
        {
            return View();
        }

    }
}
