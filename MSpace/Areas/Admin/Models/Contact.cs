using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSpace.Areas.Admin.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	Contact
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	Contact
     * 创建时间:	2013/1/30 20:12:54
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Contact说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	f6af4216-698f-4b94-80da-61cdae92ab69  
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
    public class Contact
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "姓名")]
        public string FullName { get; set; }
        [Display(Name = "姓")]
        [Required(ErrorMessage = "{0} 不能为空")]
        public string LastName { get; set; }
        [Display(Name = "名")]
        [Required(ErrorMessage = "{0} 不能为空")]
        public string FirstName { get; set; }
        [Display(Name = "电子邮件")]
        [Required(ErrorMessage = "{0} 不能为空")]
        public string Email { get; set; }
        [Display(Name = "固定电话")]
        public string Telephone { get; set; }
        [Display(Name = "手机号码")]
        public string MobilePhone { get; set; }
        [Display(Name = "住址")]
        public string Address { get; set; }
        [Display(Name = "个人网站")]
        public string Website { get; set; }
        [Display(Name = "新浪微博")]
        public string Sina { get; set; }
        [Display(Name = "腾讯微博")]
        public string Tencent { get; set; }
        [Display(Name = "生日")]
        public string Birthday { get; set; }
        [Display(Name = "性别")]
        [Required(ErrorMessage = "{0} 不能为空")]
        public string Sex { get; set; }
        [Display(Name = "关系描述")]
        public string RelationShip { get; set; }
        [Display(Name = "头像路径")]
        public string ImagePath { get; set; }
        [Display(Name = "所属组")]
        [Required(ErrorMessage = "{0} 不能为空")]
        public int GroupId { get; set; }
    }

    public class ContactGroup
    {
        [Key]
        public int Id { get; set; }
        public string GroupName { get; set; }
    }

}