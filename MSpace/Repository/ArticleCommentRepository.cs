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
     * CLR 版本:	4.0.30319.18034
     * 类 名 称:	ArticleCommentRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	ArticleCommentRepository
     * 创建时间:	2013/3/13 14:29:57
     * 作    者:	常伟华 Changweihua
	 * 版    权:	ArticleCommentRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	2a1e53dd-a5fd-41e2-a9c6-382d6e242ae5  
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
    public class ArticleCommentRepository : RepositoryBase<ArticleComment>
    {
        public override bool Add(ArticleComment model)
        {
            if (model == null)
            {
                return false;
            }
            dbContext.ArticleComments.Add(model);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Update(ArticleComment model)
        {
            if (model == null)
            {
                return false;
            }
            //NLog.LogManager.GetCurrentClassLogger().Debug("修改记录");
            dbContext.ArticleComments.Attach(model);
            dbContext.Entry<ArticleComment>(model).State = EntityState.Modified;
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override ArticleComment Find(int Id)
        {
            var model = dbContext.ArticleComments.SingleOrDefault(_ => _.Id == Id);

            return model;
        }

        public IQueryable<ArticleComment> List()
        {
            return dbContext.ArticleComments;
        }

        public IQueryable<ArticleComment> List(int id)
        {
            return dbContext.ArticleComments.Where(_ => _.ArticleId == id);
        }


    }
}