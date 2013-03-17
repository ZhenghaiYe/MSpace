using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using MSpace.Models;

namespace MSpace.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	ArticleRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	ArticleRepository
     * 创建时间:	2013/1/28 19:53:33
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ArticleRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	abf1cef3-f619-43f2-87aa-3596b5717527  
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
    public class ArticleRepository : RepositoryBase<Article>
    {
        public override bool Add(Article article)
        {
            if (article == null)
            {
                return false;
            }
            NLog.LogManager.GetCurrentClassLogger().Debug("添加记录");
            dbContext.Articles.Add(article);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Update(Article article)
        {
            if (article == null)
            {
                return false;
            }
            //NLog.LogManager.GetCurrentClassLogger().Debug("修改记录");
            dbContext.Articles.Attach(article);
            dbContext.Entry<Article>(article).State = EntityState.Modified;
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Article Find(int Id)
        {
            var article = dbContext.Articles.SingleOrDefault(_ => _.Id == Id);

            return article;
        }

        public IQueryable<Article> List()
        {
            return dbContext.Articles;
        }

        public IQueryable<Article> List(int categoryId)
        {
            return dbContext.Articles.Where(_ => _.ArticleCategoryId == categoryId);
        }


        public IQueryable<Article> List(int start, int size)
        {
            return dbContext.Articles.OrderBy(_ => _.Id).Skip(start).Take(size);
        }

    }
}