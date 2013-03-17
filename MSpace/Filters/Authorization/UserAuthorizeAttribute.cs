using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MSpace.Models;

namespace MSpace.Filters.Authorization
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	UserAuthorizeAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Authorize
     * 文 件 名:	UserAuthorizeAttribute
     * 创建时间:	2013/2/25 10:58:31
     * 作    者:	常伟华 Changweihua
	 * 版    权:	UserAuthorizeAttribute说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	98c6927c-c5b7-4275-99be-971a95b1ded9  
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
    /// 摘要
    /// </summary>
    public class UserAuthorizeAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            var user = filterContext.HttpContext.Session["CurrentUser"] as User;
            var controller = filterContext.RouteData.Values["controller"].ToString();
            var action = filterContext.RouteData.Values["action"].ToString();
            var isAllowed = this.IsAllowed(user, controller, action);

            if (!isAllowed)
            {
                filterContext.RequestContext.HttpContext.Response.Write("无权访问");
                filterContext.RequestContext.HttpContext.Response.End();
            }

        }

        bool IsAllowed(User user, string controllerName, string actionName)
        {
            return false;
        }

    }
}