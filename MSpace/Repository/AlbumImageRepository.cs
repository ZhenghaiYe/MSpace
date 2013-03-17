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
     * 类 名 称:	AlbumImageRepository
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	AlbumImageRepository
     * 创建时间:	2013/2/23 13:58:08
     * 作    者:	常伟华 Changweihua
	 * 版    权:	AlbumImageRepository说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	84633733-d1cd-402a-bf77-1fdb3b185240  
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
    public class AlbumImageRepository : RepositoryBase<AlbumImage>
    {
        public override bool Add(AlbumImage albumImage)
        {
            if (albumImage == null)
            {
                return false;
            }
            NLog.LogManager.GetCurrentClassLogger().Debug("添加记录");
            dbContext.AlbumImages.Add(albumImage);
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Update(AlbumImage albumImage)
        {
            if (albumImage == null)
            {
                return false;
            }
            //NLog.LogManager.GetCurrentClassLogger().Debug("修改记录");
            dbContext.AlbumImages.Attach(albumImage);
            dbContext.Entry<AlbumImage>(albumImage).State = EntityState.Modified;
            if (dbContext.SaveChanges() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override AlbumImage Find(int Id)
        {
            var album = dbContext.AlbumImages.SingleOrDefault(_ => _.Id == Id);

            return album;
        }

        public IQueryable<AlbumImage> List()
        {
            return dbContext.AlbumImages;
        }

        public IQueryable<AlbumImage> List(int start, int size)
        {
            return dbContext.AlbumImages.OrderBy(_ => _.Id).Skip(start).Take(size);
        }

        public IQueryable<AlbumImage> List(int albumId)
        {
            return dbContext.AlbumImages.Where(_ => _.AlbumId == albumId);
        }

    }
}