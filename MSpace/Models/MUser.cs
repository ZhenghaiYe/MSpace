using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MSpace.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	MUser
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Models
     * 文 件 名:	MUser
     * 创建时间:	2013/1/20 21:44:15
     * 作    者:	常伟华 Changweihua
	 * 版    权:	MUser说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	e7d1805d-f444-4907-96cb-f15d97aceb11  
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
    /// 第三方接入用户
    /// </summary>
    public class MUser
    {
        [Key]
        [Display(Name = "编号")]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "{0}必须填写")]
        [Display(Name = "电子邮件")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "用户名")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "密码")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "确认密码")]
        [Compare("Password")]
        public virtual string RePassword { get; set; }
        [Required]
        [Display(Name = "昵称")]
        public string NickName { get; set; }
        [Required]
        [Display(Name = "性别")]
        public Gender Gender { get; set; }
        [Required]
        [Display(Name = "地址")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "省")]
        public string Province { get; set; }
        [Required]
        [Display(Name = "市")]
        public string City { get; set; }
    }
}