using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using MSpace.Extensions;

namespace MSpace.Filters.Authorization
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	SimpleAuthorizeAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Authorize
     * 文 件 名:	SimpleAuthorizeAttribute
     * 创建时间:	2013/2/25 11:26:09
     * 作    者:	常伟华 Changweihua
	 * 版    权:	SimpleAuthorizeAttribute说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	77c22a60-7467-46c1-995e-091eb47dd904  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    /// <summary>
    /// 代码顺序为：OnAuthorization-->AuthorizeCore-->HandleUnauthorizedRequest
    /// </summary>
    public class FailedSimpleAuthorizeAttribute : AuthorizeAttribute
    {
        //bool isChecked = Convert.ToBoolean(System.Configuration.ConfigurationManager.AppSettings["SimpleAuthorizeEnabled"]);

        public new string[] Roles { get; set; }

        /// <summary>
        /// 如果AuthorizeCore返回false时，才会走HandleUnauthorizedRequest 方法，并且Request.StausCode会返回401
        /// </summary>
        /// <param name="httpContext"></param>
        /// <returns></returns>
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            //if (!isChecked)
            //{
            //    return true;
            //}

            if (httpContext == null)
            {
                throw new ArgumentNullException("httpContext");
            }

            //if (httpContext.Session["User"] == null)
            //{
            //    return false;
            //}
        
            //if (!httpContext.User.Identity.IsAuthenticated)
            //{
            //    return false;
            //}

            if (Roles == null)
            {
                return true;
            }
            if (Roles.Length == 0)
            {
                return true;
            }
            if (Roles.Any((str) => { return str == "chang"; }))
            {
                NLog.LogManager.GetCurrentClassLogger().Debug("权限通过");
                return true;
            }
            else
            {
                NLog.LogManager.GetCurrentClassLogger().Debug("没有权限");
                httpContext.Response.StatusCode = 403;
                return false;
            }
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);

            string controllerName = filterContext.ActionDescriptor.ControllerDescriptor.ControllerName;
            string actionName = filterContext.ActionDescriptor.ActionName;
            string roles = GetRoles.GetActionRoles(actionName, controllerName);
            if (!string.IsNullOrWhiteSpace(roles))
            {
                this.Roles = roles.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            }

            
        }

        protected override void HandleUnauthorizedRequest(AuthorizationContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("filterContext");
            }
            else
            {
                

                //context.HttpContext.Response.Redirect(string.Format(strUrl, HttpUtility.UrlEncode(path)), true);
                ////context.Response.Redirect(loginUrl + context.Request.Url.AbsoluteUri);
                

                if (context.HttpContext.Response.StatusCode == 403)
                {
                    //NLog.LogManager.GetCurrentClassLogger().Debug("403");
                    //context.Result = new RedirectResult("/Account/Logon");
                    string strUrl = "http://localhost:32065/Account/Logon";
                    context.HttpContext.Response.Redirect(strUrl, true);
                    //context.HttpContext.Response.Redirect("http://www.cmono.net");
                }

            }

        } 

    } 
}