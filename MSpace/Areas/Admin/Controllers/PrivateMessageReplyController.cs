using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class PrivateMessageReplyController : Controller
    {
        private PrivateMessageReplyRepository pmrr = new PrivateMessageReplyRepository();
        private PrivateMessageRepository pmr = new PrivateMessageRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Reply(int id)
        {
            ViewBag.Message = pmr.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult Reply(PrivateMessageReply model)
        {
            var flag = TryUpdateModel(model);
            if (flag)
            {
                flag = pmrr.Add(model);
                return RedirectToAction("Index", "PrivateMessage");
            }
            return View(model);
        }

        public ActionResult List(int id)
        {
            var model = pmrr.List().Where(_ => _.MessageId == id);
            return View(model);
        }


    }
}
