using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;

namespace MSpace.Extensions
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	HtmlExtension
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Extension
     * 文 件 名:	HtmlExtension
     * 创建时间:	2013/1/31 22:32:26
     * 作    者:	常伟华 Changweihua
	 * 版    权:	HtmlExtension说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	bed30f9a-9a98-4aff-9034-15ad47251fed  
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
    public static class HtmlExtension
    {
        public static MvcHtmlString MetroLabelFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, string displayText, object htmlAttributes)
        {
            string name = ExpressionHelper.GetExpressionText(expression);

            TagBuilder tagBuilder = new TagBuilder("label")
            {
                InnerHtml = displayText
            };
            tagBuilder.MergeAttribute("for", name);
            tagBuilder.MergeAttributes(new RouteValueDictionary(htmlAttributes));
            return new MvcHtmlString(tagBuilder.ToString(TagRenderMode.Normal));
        }

        public static MvcHtmlString MetroCheckBoxFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, string displayText, object htmlAttributes)
        {
            return new MvcHtmlString("<input type=\"checkbox\"><span class=\"metro-checkbox\">" + displayText + "</span>");
        }

        public static MvcHtmlString MetroRadioButtonFor<TModel, TProperty>(this HtmlHelper<TModel> helper, Expression<Func<TModel, TProperty>> expression, string displayText, object htmlAttributes)
        {
            string name = ExpressionHelper.GetExpressionText(expression);

            return new MvcHtmlString("<input id=\"" + name + "\" name=\" " + name + "\" type=\"radio\"><span class=\"metro-radio\">" + displayText + "</span>");
        }

    }
}