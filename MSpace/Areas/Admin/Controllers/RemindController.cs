using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class RemindController : Controller
    {
        private RemindRepository remindRepository = new RemindRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Remind model)
        {
            var flag = TryUpdateModel(model);

            return Json(flag);
        }

        public ActionResult ListAll()
        {
            var list = remindRepository.List();
            return Json(new { reminds = list }, JsonRequestBehavior.AllowGet);
        }

    }
}
