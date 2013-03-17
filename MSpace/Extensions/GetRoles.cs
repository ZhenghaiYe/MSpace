using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace MSpace.Extensions
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	GetRoles
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Extensions
     * 文 件 名:	GetRoles
     * 创建时间:	2013/3/17 13:00:42
     * 作    者:	常伟华 Changweihua
	 * 版    权:	GetRoles说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	daa5caef-3e0b-4306-8fad-29301dff5ac5  
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
    public class GetRoles
    {
        public static string GetActionRoles(string action, string controller)
        {
            XElement rootElement = XElement.Load(HttpContext.Current.Server.MapPath("/") + "ActionRoles.xml");
            XElement controllerElement = findElementByAttribute(rootElement, "Controller", controller);
            if (controllerElement != null)
            {
                XElement actionElement = findElementByAttribute(controllerElement, "Action", action);
                if (actionElement != null)
                {
                    return actionElement.Value;
                }
            }
            return "";
        }

        public static XElement findElementByAttribute(XElement xElement, string tagName, string attribute)
        {
            return xElement.Elements(tagName).FirstOrDefault(x => x.Attribute("name").Value.Equals(attribute, StringComparison.OrdinalIgnoreCase));
        }
    }
}