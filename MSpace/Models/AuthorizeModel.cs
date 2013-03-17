using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSpace.Models
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	AuthorizeModel
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Areas.Admin.Models
     * 文 件 名:	AuthorizeModel
     * 创建时间:	2013/2/25 10:21:26
     * 作    者:	常伟华 Changweihua
	 * 版    权:	AuthorizeModel说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	b4cf0554-8295-4564-9ea8-04cf2f123cb8  
	 *
	 * 登录用户:	Changweihua
	 * 所 属 域:	Lumia800

	 * 创建年份:	2013
     * 修改时间:
     * 修 改 人:
     * 
     ************************************************************************************/
    #endregion

    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ControllerAction
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsController { get; set; }
        public bool IsAllowedNoneRoles { get; set; }
        public bool IsAllowedRoles { get; set; }
        public string ControllerName { get; set; }
    }

    public class ControllerActionRole
    {
        public int Id { get; set; }
        public bool IsAllowed { get; set; }
        public int RoleId { get; set; }
        public int ControllerActionId { get; set; }
    }

    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
    }

    public class UserRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }
    }

}