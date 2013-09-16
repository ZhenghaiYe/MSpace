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
     * 类 名 称:	Album
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	Album
     * 创建时间:	2013/2/23 11:37:51
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Album说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	5c56b06a-3e26-489c-ba32-f8fd021dd647  
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
    public class Album
    {
        public int Id { get; set; }
        /// <summary>
        /// 相册名称
        /// </summary>
        [Display(Name = "相册名称")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "相册描述")]
        [Required]
        public string Description { get; set; }
        [Display(Name = "访问权限")]
        public string Privacy { get; set; }
        [Display(Name = "相册封面")]
        public string Cover { get; set; }

       
    }
}