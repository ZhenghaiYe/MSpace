using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Common;
using MSpace.Models;

namespace MSpace.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()　　　//此Action自动往cookie里写入登录信息
        {
            HttpCookie hcUserName = new HttpCookie("username", "admin");
            HttpCookie hcPassWord = new HttpCookie("password", "123456");
            System.Web.HttpContext.Current.Response.SetCookie(hcUserName);
            System.Web.HttpContext.Current.Response.SetCookie(hcPassWord);
            string reffer = string.Empty;
            if (Request.UrlReferrer == null)
            {
                return RedirectToRoute("DefaultRoute", new { controller = "Home", action = "Index" });
            }
            
            reffer = Request.UrlReferrer.AbsolutePath;
            return Redirect(reffer);
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(MUser user)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            return View(user);
        }

        /// <summary>
        /// 注销登录
        /// </summary>
        /// <returns></returns>
        public ActionResult Logout()
        {
            System.Web.HttpContext.Current.Response.Cookies["username"].Value = "";
            System.Web.HttpContext.Current.Response.Cookies["password"].Value = "";

            return Redirect("/Home");
        }

        public ActionResult ForgetPassword()
        {
            return View();
        }

        /// <summary>
        /// 绘制验证码
        /// </summary>
        /// <returns></returns>
        public ActionResult VerificationCode()
        {
            int _verificationLength = 6;
            int _width = 100, _height = 20;
            SizeF _verificationTextSize;
            Bitmap _bitmap = new Bitmap(Server.MapPath("~/Content/Texture.jpg"), true);
            TextureBrush _brush = new TextureBrush(_bitmap);
            //获取验证码
            string _verificationText = CheckCodeUtil.VerificationText(_verificationLength);
            //存储验证码
            Session["VerificationCode"] = _verificationText.ToUpper();
            Font _font = new Font("Arial", 14, FontStyle.Bold);
            Bitmap _image = new Bitmap(_width, _height);
            Graphics _g = Graphics.FromImage(_image);
            //清空背景色
            _g.Clear(Color.White);
            //绘制验证码
            _verificationTextSize = _g.MeasureString(_verificationText, _font);
            _g.DrawString(_verificationText, _font, _brush, (_width - _verificationTextSize.Width) / 2, (_height - _verificationTextSize.Height) / 2);
            _image.Save(Response.OutputStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            return null;
        }

    }
}
