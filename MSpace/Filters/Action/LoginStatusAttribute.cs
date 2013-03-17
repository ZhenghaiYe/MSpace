using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Filters.Action
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	LoginStatusAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Filters
     * 文 件 名:	LoginStatusAttribute
     * 创建时间:	2013/2/26 9:06:35
     * 作    者:	常伟华 Changweihua
	 * 版    权:	LoginStatusAttribute说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	6d05f7c1-12d5-44bb-8ce4-41d474c43157  
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
    public class LoginStatusAttribute : ActionFilterAttribute
    {
        bool flag = false;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            
            if (filterContext.HttpContext.Session["User"] != null)
            {
                flag = true;
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            if (filterContext.Result is ViewResult)
            {
                ((ViewResult)filterContext.Result).ViewData["LoginStatus"] = flag;
            }
        }
    }
}