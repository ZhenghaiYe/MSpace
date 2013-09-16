using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using MSpace.Models;

namespace MSpace.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	MSpaceContext
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	MSpaceContext
     * 创建时间:	2013/1/24 13:30:44
     * 作    者:	常伟华 Changweihua
     * 版    权:	本代码版权归常伟华所有 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	9b7124f4-4f56-4254-af6a-fa6ceed3a6f4  
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
    public class MSpaceDB : DbContext
    {
        public DbSet<MUser> MUsers { get; set; }
        public DbSet<ArticleType> ArticleTypes { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        public DbSet<RssSource> RssSources { get; set; }
        public DbSet<Twitter> Twitters { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<ContactGroup> ContactGroups { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<AlbumImage> AlbumImages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Component> Components { get; set; }
        public DbSet<ArticleComment> ArticleComments { get; set; }
        public DbSet<SiteNews> SiteNewss { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PrivateMessage> PrivateMessages { get; set; }
        public DbSet<PrivateMessageStatus> PrivateMessageStatuses { get; set; }
        public DbSet<PrivateMessageReply> PrivateMessageReplys { get; set; }
        public DbSet<Remind> Reminds { get; set; }
        public DbSet<RemindStatus> RemindStatuss { get; set; }
        public DbSet<RemindCycle> RemindCycles { get; set; }


        public MSpaceDB()
            : base("MSpaceDB")
        {
            Database.SetInitializer(new MSpaceDBInitializer());
        }

    }
}