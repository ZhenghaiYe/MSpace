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
     * 类 名 称:	Article
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	Article
     * 创建时间:	2013/1/22 16:28:24
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Article说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	81703c5c-990b-4c02-88a0-0c932f768414  
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
    public class Article
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        /// <summary>
        /// 标题
        /// </summary>
        [Display(Name = "标题")]
        [Required(ErrorMessage = "{0} 必须填写")]
        public string Title { get; set; }
        /// <summary>
        /// 摘要
        /// </summary>
        [Display(Name = "摘要")]
        public string Summary { get; set; }
        /// <summary>
        /// 内容
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 作者名称
        /// </summary>
        public string AuthorName { get; set; }
        /// <summary>
        /// 文章类型编号
        /// </summary>
        [Display(Name = "文章类型")]
        [Required(ErrorMessage = "{0} 必须选择")]
        public int ArticleTypeId { get; set; }
        /// <summary>
        /// 文章分类
        /// </summary>
        [Display(Name = "文章分类")]
        public int ArticleCategoryId { get; set; }
        public string ArticleTag { get; set; }
        /// <summary>
        /// 是否加密
        /// </summary>
        public int IsSecret { get; set; }
        /// <summary>
        /// 是否置顶
        /// </summary>
        public bool IsTop { get; set; }
        /// <summary>
        /// 是否允许评论
        /// </summary>
        public int IsAllowComment { get; set; }
        /// <summary>
        /// 发布日期
        /// </summary>
        public string PubDate { get; set; }
        public int ViewCount { get; set; }
        public int CommentCount { get; set; }
        public int Grade { get; set; }
    }
}