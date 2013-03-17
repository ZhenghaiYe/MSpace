using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Filters.Action
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	ExecutionTimingAttribute
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Filters
     * 文 件 名:	ExecutionTimingAttribute
     * 创建时间:	2013/2/25 10:10:24
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ExecutionTimingAttribute说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	54a89c4c-ccbe-4c36-87d7-2dee407e41f2  
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
    public class ExecutionTimingAttribute : ActionFilterAttribute 
    {
        private bool timingEnabled = bool.Parse(ConfigurationManager.AppSettings["TimingEnabled"]);
        private Stopwatch timer;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
            if (this.timingEnabled)
            {
                this.timer = new Stopwatch();
                this.timer.Start();
            }
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            base.OnActionExecuted(filterContext);
            if (this.timingEnabled)
            {
                this.timer.Stop();
                Trace.WriteLine(string.Format(CultureInfo.InvariantCulture, "执行时间: {0}ms", this.timer.ElapsedMilliseconds));
                if (filterContext.Result is ViewResult)
                {
                    ((ViewResult)filterContext.Result).ViewData["ExecutionTime"] = this.timer.ElapsedMilliseconds;
                }
            }
        }
    } 
}