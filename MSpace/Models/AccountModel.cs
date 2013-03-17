using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MSpace.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	AccountModel
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Models
     * 文 件 名:	AccountModel
     * 创建时间:	2013/2/25 12:03:02
     * 作    者:	常伟华 Changweihua
	 * 版    权:	AccountModel说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	e6577d8f-6356-48d8-b57c-c9bd8fd4bd9b  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    public class LogonModel
    {
        [Required]
        [Display(Name = "用户名")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "密码")]
        public string Password { get; set; }
        public bool IsRemember { get; set; }
        public string CheckCode { get; set; }
    }
}