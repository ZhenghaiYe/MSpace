using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSpace.Areas.Admin.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	RssEntity
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	RssEntity
     * 创建时间:	2013/1/29 14:07:00
     * 作    者:	常伟华 Changweihua
	 * 版    权:	RssEntity说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	5465df7a-a53e-49a9-bf5e-e426d249b971  
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
    public class RssEntity
    {
        /// <summary>
        /// 文章编号
        /// </summary>
        /// 
        public int Id;
        /// <summary>
        /// 文章链接
        /// </summary>
        /// 
        public string Link;
        /// <summary>
        /// 文章标题
        /// </summary>
        /// 
        public string Title;
        /// <summary>
        /// 发布时间
        /// </summary>
        /// 
        public string PubDate;
        /// <summary>
        /// 摘要
        /// </summary>
        /// 
        public string Description;
        /// <summary>
        /// 唯一标识
        /// </summary>
        /// 
        public string Guid;
        /// <summary>
        /// 作者
        /// </summary>
        /// 
        public string Author;
    }

}