using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Areas.Admin.Controllers
{
    public class TwitterController : AdminBaseController
    {
        //
        // GET: /Admin/Twitter/
        private TwitterRepository repository = new TwitterRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            var list = repository.List();

            return Json(list, JsonRequestBehavior.AllowGet);
        }


        public ActionResult Write()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Write(Twitter twitter)
        {
            TryUpdateModel(twitter, new string[] { "Content"});
            if (ModelState.IsValid)
            {
                twitter.PublishDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                twitter.Author = "常伟华";
                repository.Add(twitter);
            }
            return View("Index");
        }

    }
}
