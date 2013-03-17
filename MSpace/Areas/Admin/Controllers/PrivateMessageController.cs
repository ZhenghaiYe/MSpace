using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class PrivateMessageController : Controller
    {
        private PrivateMessageRepository privateMessageRepository = new PrivateMessageRepository();

        [HttpPost]
        public ActionResult Publish(PrivateMessage model)
        {
            var flag = TryUpdateModel<PrivateMessage>(model, new string[] { "Name", "Email", "Content" });
            string msg = string.Empty;
            if (flag)
            {
                model.PublishDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                model.StatusId = 1;
                privateMessageRepository.Add(model);
                msg = "发表成功";

            }
            else
            {
                msg = "发表失败";
            }
            return Json(new { flag = flag, msg = msg }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListReply(int id)
        {
            var list =privateMessageRepository.Find(id).Replys;
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Reply(int id)
        {
            var model = privateMessageRepository.Find(id);
            if (model == null)
            {
                return View("Index");
            }
            return View();
        }

        public ActionResult Read(int id)
        {
            var model = privateMessageRepository.Find(id);
            if (model == null)
            {
                return View("Index");
            }
            ViewBag.EmailHash = CLib.CSecurity.MD5Helper.GetMD5(model.Email.ToLower()).ToLower();
            return View(model);
        }

        public ActionResult List()
        {
            var list = privateMessageRepository.List().ToList().Select((m, index) => new { id = m.MessageId, name = m.Name, hash = CLib.CSecurity.MD5Helper.GetMD5(m.Email ?? "changweihua@outlook.com").ToLower(), content = m.Content, status = m.Status.Description, publishDate = m.PublishDate });
            return Json(new { messages = list }, JsonRequestBehavior.AllowGet);
        }

    }
}
