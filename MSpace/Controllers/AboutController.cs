using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Controllers
{
    public class AboutController : Controller
    {
        //
        // GET: /About/

        public ActionResult Index()
        {
            return PartialView();
        }

        public ActionResult Resume()
        {
            return PartialView();
        }

        public ActionResult Experience()
        {
            return PartialView();
        }

        public ActionResult Plan()
        {
            return PartialView();
        }

    }
}
