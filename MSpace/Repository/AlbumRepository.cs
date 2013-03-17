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
     * 类 名 称:	AlbumRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	AlbumRepository
     * 创建时间:	2013/2/23 13:10:31
     * 作    者:	常伟华 Changweihua
	 * 版    权:	AlbumRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	7aa11b61-0ed4-41a2-acf8-8079a3ee09a7  
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
    public class AlbumRepository : RepositoryBase<Album>
    {
        public override bool Add(Album album)
        {
            if (album == null)
            {
                return false;
            }
            NLog.LogManager.GetCurrentClassLogger().Debug("添加记录");
            dbContext.Albums.Add(album);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Update(Album album)
        {
            if (album == null)
            {
                return false;
            }
            //NLog.LogManager.GetCurrentClassLogger().Debug("修改记录");
            dbContext.Albums.Attach(album);
            dbContext.Entry<Album>(album).State = EntityState.Modified;
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override Album Find(int Id)
        {
            var album = dbContext.Albums.SingleOrDefault(_ => _.Id == Id);

            return album;
        }

        public IQueryable<Album> List()
        {
            return dbContext.Albums;
        }

        public IQueryable<Album> List(int start, int size)
        {
            return dbContext.Albums.OrderBy(_ => _.Id).Skip(start).Take(size);
        }
    }
}