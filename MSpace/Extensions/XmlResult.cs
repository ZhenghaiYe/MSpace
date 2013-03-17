using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml.Serialization;

namespace MSpace.Extensions
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	XmlResult
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Extensions
     * 文 件 名:	XmlResult
     * 创建时间:	2013/3/17 12:21:13
     * 作    者:	常伟华 Changweihua
	 * 版    权:	XmlResult说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	275f94dc-ecb5-46ee-bb1e-fab49816bc25  
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
    public class XmlResult : ActionResult
    {
        public XmlResult(Object data)
        {
            this.Data = data;
        }
        public Object Data
        {
            get;
            set;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            if (Data == null)
            {
                new EmptyResult().ExecuteResult(context);
                return;
            }
            context.HttpContext.Response.ContentType = "application/xml";
            using (MemoryStream ms = new MemoryStream())
            {
                XmlSerializer xs = new XmlSerializer(Data.GetType());
                xs.Serialize(ms, Data);
                ms.Position = 0;
                using (StreamReader sr = new StreamReader(ms))
                {
                    context.HttpContext.Response.Output.Write(sr.ReadToEnd());
                }
            }
        }
    }
}