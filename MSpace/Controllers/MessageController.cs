using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Controllers
{
    public class MessageController : Controller
    {

        private MessageRepository messageRepository = new MessageRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Publish()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Publish(Message model)
        {
            var flag = TryUpdateModel<Message>(model, new string[] { "Name", "Email", "Content" });
            string msg = string.Empty;
            if (flag)
            {
                model.PublishDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                messageRepository.Add(model);
                msg = "发表成功";

            }
            else
            {
                msg = "发表失败";
            }
            return Json(new { flag = flag, msg = msg }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult List()
        {
            var list = messageRepository.List().ToList().Select((c, index) => new { id = c.Id, hash = CLib.CSecurity.MD5Helper.GetMD5(c.Email ?? "changweihua@outlook.com").ToLower(), content = c.Content, name = c.Name, pubDate = c.PublishDate }); ;
            return Json(new { messages = list }, JsonRequestBehavior.AllowGet);
        } 

    }
}
