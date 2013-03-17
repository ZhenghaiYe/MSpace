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
     * 类 名 称:	PrivateMessageReply
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Models
     * 文 件 名:	PrivateMessageReply
     * 创建时间:	2013/3/15 20:21:02
     * 作    者:	常伟华 Changweihua
	 * 版    权:	PrivateMessageReply说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	71d49e32-6f36-442b-816c-41104a5086e9  
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
    public class PrivateMessageReply
    {
        [Key]
        public int ReplyId { get; set; }
        public virtual int MessageId { get; set; }
        [Required]
        public string ReplyContent { get; set; }
    }
}