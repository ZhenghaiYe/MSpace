using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Web;
using MSpace.Models;

namespace MSpace.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	ArticleCategoryRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	ArticleCategoryRepository
     * 创建时间:	2013/1/24 13:40:34
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ArticleCategoryRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	423e24af-6874-41bc-94c3-0171cc659fe3  
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
    public class ArticleCategoryRepository : RepositoryBase<ArticleCategory>
    {
        public override bool Add(ArticleCategory Tmodel)
        {
            if (Tmodel == null)
            {
                return false;
            }
            //NLog.LogManager.GetCurrentClassLogger().Debug("添加记录");
            dbContext.ArticleCategories.Add(Tmodel);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Update(ArticleCategory category)
        {
            if (category == null)
            {
                return false;
            }
            //NLog.LogManager.GetCurrentClassLogger().Debug("修改记录");
            dbContext.ArticleCategories.Attach(category);
            dbContext.Entry<ArticleCategory>(category).State = EntityState.Modified;
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
            ArticleCategory category = dbContext.ArticleCategories.SingleOrDefault(_ => _.Id == Id);
            if (category == null)
            {
                return false;
            }
            dbContext.ArticleCategories.Remove(category);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ArticleCategory Find(int Id)
        {
            return dbContext.ArticleCategories.SingleOrDefault(_ => _.Id == Id);
        }

        public IQueryable<ArticleCategory> List()
        {
            return dbContext.ArticleCategories;
        }
    }
}