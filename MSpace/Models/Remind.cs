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
     * 类 名 称:	Remind
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Models
     * 文 件 名:	Remind
     * 创建时间:	2013/3/16 15:32:14
     * 作    者:	常伟华 Changweihua
	 * 版    权:	Remind说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	4f2e3ce6-8ef8-47ba-a02b-0c6d889126db  
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
    public class Remind
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Location { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public virtual int CycleId { get; set; }
        public virtual RemindCycle Cycle { get; set; }
        public virtual int StatusId { get; set; }
        public virtual RemindStatus Status { get; set; }
    }

    public class RemindCycle
    {
        [Key]
        public int CycleId { get; set; }
        public string CycleName { get; set; }
    }

    public class RemindStatus
    {
        [Key]
        public int StatusId { get; set; }
        public string StatusName { get; set; }
    }

}