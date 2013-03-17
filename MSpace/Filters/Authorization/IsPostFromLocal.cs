using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Filters.Authorization
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	IsPostFromLocal
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Filters
     * 文 件 名:	IsPostFromLocal
     * 创建时间:	2013/3/13 23:16:17
     * 作    者:	常伟华 Changweihua
	 * 版    权:	IsPostFromLocal说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	524acc81-8489-4c8c-8389-b563687f952a  
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
    /// HttpReferrer阻击CSRF攻击
    /// </summary>
    public class IsPostFromLocal : AuthorizeAttribute
    {
        private string Host = ConfigurationManager.AppSettings["Host"].ToString();

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext != null)
            {
                if (filterContext.HttpContext.Request.UrlReferrer==null)
                {
                    throw new HttpException("无效的提交操作");
                }

                if (filterContext.HttpContext.Request.UrlReferrer.Host != Host)
                {
                    throw new HttpException("提交操作不是来自本站");
                }

            }
        }
    }
}