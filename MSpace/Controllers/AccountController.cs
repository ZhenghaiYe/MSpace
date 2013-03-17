using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;
using MSpace.Repository;

namespace MSpace.Controllers
{
    public class AccountController : Controller
    {
        private UserRepository userRepository = new UserRepository();

        public ActionResult LogOn()
        {
            bool isRemember = Request.Cookies["IsRemember"] == null || Convert.ToBoolean(Request.Cookies["IsRemember"].Value);
            NLog.LogManager.GetCurrentClassLogger().Debug("是否记住密码" + isRemember);
            return View(new LogonModel { IsRemember = isRemember });
        }

        public ActionResult LogOut()
        {
            HttpContext.Session.Remove("User");
            return Redirect("/home");
        }

        public ActionResult LogOnSuccess()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]//令牌验证，阻止CSRF攻击
        public ActionResult LogOn(LogonModel model)
        {
            TryValidateModel(model);
            if (ModelState.IsValid)
            {
                if (HttpContext.Session["VerificationCode"] == null || string.Compare(model.CheckCode, HttpContext.Session["VerificationCode"].ToString(), true) != 0)
                {
                    ModelState.AddModelError("CheckCode", "错误");
                    return View(model);
                }

                if (userRepository.ValidateUser(model.Name, model.Password))
                {
                    if (model.IsRemember)
                    {
                        NLog.LogManager.GetCurrentClassLogger().Debug("记住密码");
                        Response.Cookies.Add(new HttpCookie("IsRemember", "true"));
                    }
                    else
                    {
                        NLog.LogManager.GetCurrentClassLogger().Debug("不记住密码");
                        //var cookie = Request.Cookies["IsRemember"];
                        //cookie.Expires = DateTime.Now.AddDays(-1);
                        //Response.AppendCookie(cookie);
                        //Request.Cookies.Remove("IsRemember");
                        Response.Cookies.Add(new HttpCookie("IsRemember", "false"));
                    }
                    HttpContext.Session.Add("User", model);
                    return Redirect("/admin");
                }
                else
                {
                    ModelState.AddModelError("Name", "错误");
                    ModelState.AddModelError("Password", "错误");
                    return View(model);
                }
            }
            else
            {
                return View();
            }
        }

    }
}
