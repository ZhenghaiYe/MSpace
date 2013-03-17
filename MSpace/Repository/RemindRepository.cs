using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MSpace.Models;

namespace MSpace.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	RemindRepoistory
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	RemindRepoistory
     * 创建时间:	2013/3/16 15:37:42
     * 作    者:	常伟华 Changweihua
	 * 版    权:	RemindRepoistory说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	7a2a8e81-ae0a-4e5c-96eb-6e793f481bb9  
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
    public class RemindRepository : RepositoryBase<Remind>
    {
        public override bool Add(Remind Tmodel)
        {
            if (Tmodel == null)
            {
                return false;
            }
            dbContext.Reminds.Add(Tmodel);
            int count = dbContext.SaveChanges();
            if (count == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IQueryable<Remind> List()
        {
            return dbContext.Reminds;
        }

    }
}