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
     * 类 名 称:	PrivateMessage
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Models
     * 文 件 名:	PrivateMessage
     * 创建时间:	2013/3/15 20:20:47
     * 作    者:	常伟华 Changweihua
	 * 版    权:	PrivateMessage说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	4efadf9a-9a3f-4ec2-a783-2597a9ad6fe1  
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
    public class PrivateMessage
    {
        [Key]
        public int MessageId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        [Required]
        public string Content { get; set; }
        public string PublishDate { get; set; }
        public virtual int StatusId { get; set; }

        public virtual PrivateMessageStatus Status { get; set; }
        public virtual List<PrivateMessageReply> Replys { get; set; }

    }

    public class PrivateMessageStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string Description { get; set; }
    }

}