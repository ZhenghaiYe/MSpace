using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSpace.Areas.Admin.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	ArticleTag
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	ArticleTag
     * 创建时间:	2013/1/22 23:27:49
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ArticleTag说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	405eeb3d-cae6-49ba-aba1-7352b1bc4fbb  
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
    public class ArticleTag
    {
        /// <summary>
        /// 博客标签编号
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 标签编号
        /// </summary>
        public int TagId { get; set; }

        public int ArticleId { get; set; }
        public int Status { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime ModifyTime { get; set; }
    }
}