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
     * 类 名 称:	Twitter
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	Twitter
     * 创建时间:	2013/1/22 18:37:44
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Twitter说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	28637ef6-e225-47f0-8330-a0a5c0462e71  
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
    public class Twitter
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "日期")]
        public string PublishDate { get; set; }
        [Display(Name = "作者")]
        public string Author { get; set; }
        [Display(Name = "内容")]
        [Required(ErrorMessage = "{0} 至少也得意思意思一下吧")]
        public string Content { get; set; }
    }
}