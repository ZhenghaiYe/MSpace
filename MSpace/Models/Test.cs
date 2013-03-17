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
     * 类 名 称:	Test
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Models
     * 文 件 名:	Test
     * 创建时间:	2013/2/3 20:43:19
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Test说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	9d94ba3b-025c-4258-b226-6ab604910556  
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
    public class Test
    {
        [Key]
        [ScaffoldColumn(true)]
        public int Id { get; set; }
        [Required(ErrorMessage="{0}必须填写的啦")]
        public string Name { get; set; }
    }
}