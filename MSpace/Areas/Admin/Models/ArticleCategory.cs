using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSpace.Areas.Admin.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	ArticleCategory
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	ArticleCategory
     * 创建时间:	2013/1/22 23:28:04
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ArticleCategory说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	1a8985c0-699f-4a85-8394-aa7339f94fbc  
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
    public class ArticleCategory
    {
        /// <summary>
        /// 类别ID
        /// </summary>
        [Key]
        [Display(Name = "类别编号")]
        public int Id { get; set; }
        /// <summary>
        /// 父级ID
        /// </summary>
        [Display(Name = "父分类")]
        [Required(ErrorMessage = "{0} 必须填写")]
        public int ParentId { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        [Display(Name="类别名称")]
        [Required(ErrorMessage="{0} 必须填写")]
        public string CategoryName { get; set; }
        /// <summary>
        /// 别名
        /// </summary>
        [Display(Name = "别名")]
        [Required(ErrorMessage = "{0} 必须填写")]
        public string LinkName { get; set; }
        /// <summary>
        ///类别链接地址 
        /// </summary>
        [Display(Name = "链接地址")]
        [Required(ErrorMessage = "{0} 必须填写")]
        public string LinkUrl { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        [Display(Name = "状态")]
        public int? Status { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        [Display(Name = "排序")]
        [Required(ErrorMessage = "{0} 必须填写")]
        public int SortOrder { get; set; }
    }
}