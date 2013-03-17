using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSpace.Areas.Admin.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	AlbumImage
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	AlbumImage
     * 创建时间:	2013/2/23 13:56:24
     * 作    者:	常伟华 Changweihua
	 * 版    权:	AlbumImage说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	45863fa6-6d4f-457a-be9b-4754adf85acf  
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
    public class AlbumImage
    {
        public int Id { get; set; }
        public string OriginName { get; set; }
        public string NewName { get; set; }
        public string Url { get; set; }
        public int AlbumId { get; set; }
    }
}