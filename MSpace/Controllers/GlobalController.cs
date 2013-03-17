using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Repository;

namespace MSpace.Controllers
{
    public class GlobalController : Controller
    {
        //
        // GET: /Global/

        private TwitterRepository twitterRepository = new TwitterRepository();
        private ArticleRepository articleRepository = new ArticleRepository();
        private ComponentRepository componentRepository = new ComponentRepository();
        private SiteNewsRepository siteNewsRepository = new SiteNewsRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Component()
        {
            var list = componentRepository.List();
            return PartialView(list);
        }

        /// <summary>
        /// 验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult VerificationCode()
        {
            CLib.CImage.VerificationCode vc = new CLib.CImage.VerificationCode();
            string code = vc.CreateVerifyCode();
            NLog.LogManager.GetCurrentClassLogger().Debug(code);
            //存储验证码
            Session["VerificationCode"] = code.ToUpper();
            //输出验证码
            vc.CreateImageCode(code).Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Gif);
            return null;
        }


        public ActionResult CheckVerificationCode(string inputCode)
        {
            string code = Session["VerificationCode"] == null ? "" : Session["VerificationCode"].ToString();
            //输出验证码
            var flag = string.Compare(code, inputCode, true) == 0 ? true : false;

            return Json(flag);
        }

        public ActionResult LatestNews()
        {
            var list = siteNewsRepository.List();
            return Json(list, JsonRequestBehavior.AllowGet);
        }
         

        public ActionResult Footer()
        {
            return View();
        }

        public ActionResult Header()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult Online()
        {
            return PartialView();
        }

        [ChildActionOnly]
        public ActionResult Outline()
        {
            return PartialView();
        }

        public ActionResult Twitter()
        {
            var list = twitterRepository.List().ToList().Select((t, index) => new { Content = t.Content.Length > 5 ? t.Content.Substring(0, 5).ToString() : t.Content, PubDate = t.PublishDate }).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Article()
        {
            var list = articleRepository.List().ToList().Select((a, index) => new { Title = a.Title, PubDate = a.PubDate }).ToList();
            return Json(list, JsonRequestBehavior.AllowGet);
        }

        public ActionResult FamousWord()
        {
            return PartialView();
        }

        public ActionResult BlogRoll()
        {
            return PartialView();
        }

        /// <summary>
        /// 版权信息
        /// </summary>
        /// <returns></returns>
        public ActionResult CopyRight()
        {
            return PartialView();
        }


    }
}
