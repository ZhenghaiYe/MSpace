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
     * 类 名 称:	SiteNewsRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	SiteNewsRepository
     * 创建时间:	2013/3/14 15:48:49
     * 作    者:	常伟华 Changweihua
	 * 版    权:	SiteNewsRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	2a9e5b1d-b5c5-4c5e-b4f1-91f059eb19ef  
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
    public class SiteNewsRepository : RepositoryBase<SiteNews>
    {
        public override bool Add(SiteNews Tmodel)
        {
            if (Tmodel == null)
            {
                return false;
            }
            dbContext.SiteNewss.Add(Tmodel);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Delete(int Id)
        {
            SiteNews model = dbContext.SiteNewss.SingleOrDefault(_ => _.Id == Id);
            if (model == null)
            {
                return false;
            }
            dbContext.SiteNewss.Remove(model);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IQueryable<SiteNews> List()
        {
            return dbContext.SiteNewss;
        }
    }
}