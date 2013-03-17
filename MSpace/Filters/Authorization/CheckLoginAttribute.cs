using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Filters.Authorization
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	CheckLoginAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Filters.Authorization
     * 文 件 名:	CheckLoginAttribute
     * 创建时间:	2013/3/17 12:36:38
     * 作    者:	常伟华 Changweihua
	 * 版    权:	CheckLoginAttribute说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	1e299dee-a127-4d89-b26d-a916f633d6e6  
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
    public class CheckLoginAttribute : AuthorizeAttribute
    {
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool Pass = false;
            if (true)
            {
                httpContext.Response.StatusCode = 401;//无权限状态码
                Pass = false;
            }
            else 
            {
                Pass = true;
            }

            return Pass;
        }

       

        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            base.HandleUnauthorizedRequest(filterContext);
            if (filterContext.HttpContext.Response.StatusCode == 401)
            {
                filterContext.Result = new RedirectResult("/");
            }
        }
    }
}