using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MSpace.Filters.Action
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	CheckLogin
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Filters
     * 文 件 名:	CheckLogin
     * 创建时间:	2013/3/17 11:55:37
     * 作    者:	常伟华 Changweihua
	 * 版    权:	CheckLogin说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	5b53f61d-f431-446d-95b1-400a9cbf2ad1  
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
    public class CheckLoginViaActionFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        private void ErrorRedirect(ActionExecutingContext filterContext)
        {

            filterContext.Result = new RedirectToRouteResult("Default", new RouteValueDictionary(new
            {
                controller = "Home",
                action = "Default"
            }));
        } // end
    }
}