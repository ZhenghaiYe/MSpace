using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MSpace.Models;

namespace MSpace.Repository
{
    #region 关于
    /*************************************************************************************
     * CLR 版本:	4.0.30319.17929
     * 类 名 称:	MSpaceContextInitializer
     * 机器名称:	LUMIA800
     * 命名空间:	MSpace.Repository
     * 文 件 名:	MSpaceContextInitializer
     * 创建时间:	2013/1/24 13:33:02
     * 作    者:	常伟华 Changweihua
	 * 版    权:	MSpaceContextInitializer说明：本代码版权归常伟华所有，使用时必须带上常伟华网站地址 All Rights Reserved (C) 2013 - 2014
     * 签    名:	To be or not, it is not a problem !
     * 网    站:	http://www.cmono.net
     * 邮    箱:	changweihua@outlook.com  
     * 唯一标识:	12e2dd25-247c-492e-8006-4cd0405381f4  
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
    public class MSpaceDBInitializer : DropCreateDatabaseIfModelChanges<MSpaceDB>
    //public class MSpaceDBInitializer : DropCreateDatabaseAlways<MSpaceDB>
    //public class MSpaceDBInitializer : MigrateDatabaseToLatestVersion<MSpaceContext, MSpaceContextConfiguration>
    {

        protected override void Seed(MSpaceDB context)
        {
            context.ArticleCategories.Add(new ArticleCategory { CategoryName = "C#", LinkName = "csharp", SortOrder = 1, LinkUrl = "www.cmono.net/csharp", ParentId = 0, Status = 1 });
            context.ArticleTypes.Add(new ArticleType { TypeName = "原创" });
            context.ArticleTypes.Add(new ArticleType { TypeName = "翻译" });
            context.ArticleTypes.Add(new ArticleType { TypeName = "转帖" });
            context.ContactGroups.Add(new ContactGroup { GroupName = "Group One" });
            context.ContactGroups.Add(new ContactGroup { GroupName = "Group Two" });
            context.Albums.Add(new Album { Description = "我的手机", Name = "Nokia Lumia 800", Privacy = "公开", Cover = "223366" });
            context.Users.Add(new User { UserName = "changweihua", Password = "changweihua" });
            context.Messages.Add(new Message { Name = "常伟华", Content = "测试留言" });
            context.PrivateMessageStatuses.Add(new PrivateMessageStatus { Description = "未读" });
            context.PrivateMessageStatuses.Add(new PrivateMessageStatus { Description = "已读" });
            context.PrivateMessageStatuses.Add(new PrivateMessageStatus { Description = "已删除" });
            context.RemindCycles.Add(new RemindCycle { CycleName = "一次" });
            context.RemindCycles.Add(new RemindCycle { CycleName = "每天" });
            context.RemindCycles.Add(new RemindCycle { CycleName = "周末" });
            context.RemindStatuss.Add(new RemindStatus { StatusName = "关闭" });
            context.RemindStatuss.Add(new RemindStatus { StatusName = "开启" });
            //context.RemindStatuss.Add(new RemindStatus { StatusName = "每周" });

            //context.Users.Add(new User { ID = 2, Name = "tom", Password = "tom", Roles = new[] { "manager" } });
            //context.Users.Add(new User { ID = 3, Name = "admin", Password = "admin", Roles = new[] { "admin" } });
            base.Seed(context);

        }
    }
}