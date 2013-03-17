using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Areas.Admin.Controllers
{
    public class CalendarController : AdminBaseController
    {
        //
        // GET: /Admin/Calendar/

        public ActionResult Index()
        {
            return View("FullCalendar");
        }

        public ActionResult FullCalendar()
        {
            return View();
        }
    }
}
