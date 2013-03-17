using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MSpace.Models;

namespace MSpace.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	MUserRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	MUserRepository
     * 创建时间:	2013/1/24 13:33:57
     * 作    者:	常伟华 Changweihua
	 * 版    权:	MUserRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	36b186b8-b9b5-46de-a4a8-f9cc8ded48a4  
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
    public class MUserRepository : RepositoryBase<MUser>
    {
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="articleCategory"></param>
        /// <returns></returns>
        public override bool Add(MUser muser)
        {
            if (muser == null)
            {
                return false;
            }
            dbContext.MUsers.Add(muser);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 用户列表
        /// </summary>
        /// <returns></returns>
        public IQueryable<MUser> List()
        {
            return dbContext.MUsers;
        }
    }
}