using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Controllers
{
    public class ArticleCommentController : Controller
    {
        private ArticleRepository articleRepository = new ArticleRepository();
        private ArticleCommentRepository articleCommentRepository = new ArticleCommentRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Comment()
        {
            return PartialView();
        }

        public ActionResult List(int id)
        {
            var list = articleCommentRepository.List(id).OfType<ArticleComment>().ToList().Select((c, index) => new { id = c.Id, hash = CLib.CSecurity.MD5Helper.GetMD5(c.Email ?? "changweihua@outlook.com").ToLower(), content = c.Content, name = c.Name });
            return Json(new { comments = list }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Comment(ArticleComment model)
        {
            var flag = TryValidateModel(model);
            bool actionFlag = true;
            string msg = "";
            if (flag)
            {
                articleCommentRepository.Add(model);
                msg = "评论成功";
            }
            else
            {
                actionFlag = false;
                msg = "评论失败";
            }

            return Json(new { success = actionFlag, message = msg }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public ActionResult Star(int id)
        {
            int score = Convert.ToInt32(Request.Params["score"]);
            var model = articleRepository.Find(id);
            model.Grade += score;
            articleRepository.Update(model);
            var flag = true;
            var msg = "评价成功";
            var currentScore = model.Grade;
            return Json(new { success = flag, message = msg, score = currentScore }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ListArticleComment(int id)
        {
            return PartialView();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SaveComment()
        {
            var flag = true;
            return Json(flag, JsonRequestBehavior.AllowGet);
        }

    }
}
