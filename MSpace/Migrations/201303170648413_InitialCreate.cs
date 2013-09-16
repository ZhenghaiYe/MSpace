namespace MSpace.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MUsers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        RePassword = c.String(nullable: false),
                        NickName = c.String(nullable: false),
                        Address = c.String(nullable: false),
                        Province = c.String(nullable: false),
                        City = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Articles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Summary = c.String(),
                        Content = c.String(),
                        AuthorName = c.String(),
                        ArticleTypeId = c.Int(nullable: false),
                        ArticleCategoryId = c.Int(nullable: false),
                        ArticleTag = c.String(),
                        IsSecret = c.Int(nullable: false),
                        IsTop = c.Boolean(nullable: false),
                        IsAllowComment = c.Int(nullable: false),
                        PubDate = c.String(),
                        ViewCount = c.Int(nullable: false),
                        CommentCount = c.Int(nullable: false),
                        Grade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParentId = c.Int(nullable: false),
                        CategoryName = c.String(nullable: false),
                        LinkName = c.String(nullable: false),
                        LinkUrl = c.String(nullable: false),
                        Status = c.Int(),
                        SortOrder = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RssSources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SourceName = c.String(nullable: false),
                        SourceUrl = c.String(nullable: false),
                        SourceDescription = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Twitters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PublishDate = c.String(),
                        Author = c.String(),
                        Content = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FullName = c.String(),
                        LastName = c.String(nullable: false),
                        FirstName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Telephone = c.String(),
                        MobilePhone = c.String(),
                        Address = c.String(),
                        Website = c.String(),
                        Sina = c.String(),
                        Tencent = c.String(),
                        Birthday = c.String(),
                        Sex = c.String(nullable: false),
                        RelationShip = c.String(),
                        ImagePath = c.String(),
                        GroupId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ContactGroups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GroupName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Albums",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Description = c.String(nullable: false),
                        Privacy = c.String(),
                        Cover = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AlbumImages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OriginName = c.String(),
                        NewName = c.String(),
                        Url = c.String(),
                        AlbumId = c.Int(nullable: false),
                        Score = c.Int(nullable: false),
                        ViewCount = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Components",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        IsEnable = c.Boolean(nullable: false),
                        Order = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ArticleComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ArticleId = c.Int(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Website = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.SiteNews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Content = c.String(nullable: false),
                        PublishDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(),
                        Content = c.String(nullable: false),
                        PublishDate = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PrivateMessages",
                c => new
                    {
                        MessageId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(),
                        Content = c.String(nullable: false),
                        PublishDate = c.String(),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MessageId)
                .ForeignKey("dbo.PrivateMessageStatus", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.PrivateMessageStatus",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
            CreateTable(
                "dbo.PrivateMessageReplies",
                c => new
                    {
                        ReplyId = c.Int(nullable: false, identity: true),
                        MessageId = c.Int(nullable: false),
                        ReplyContent = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ReplyId)
                .ForeignKey("dbo.PrivateMessages", t => t.MessageId, cascadeDelete: true)
                .Index(t => t.MessageId);
            
            CreateTable(
                "dbo.Reminds",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        Location = c.String(),
                        StartDate = c.String(),
                        EndDate = c.String(),
                        CycleId = c.Int(nullable: false),
                        StatusId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.RemindCycles", t => t.CycleId, cascadeDelete: true)
                .ForeignKey("dbo.RemindStatus", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.CycleId)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.RemindCycles",
                c => new
                    {
                        CycleId = c.Int(nullable: false, identity: true),
                        CycleName = c.String(),
                    })
                .PrimaryKey(t => t.CycleId);
            
            CreateTable(
                "dbo.RemindStatus",
                c => new
                    {
                        StatusId = c.Int(nullable: false, identity: true),
                        StatusName = c.String(),
                    })
                .PrimaryKey(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Reminds", new[] { "StatusId" });
            DropIndex("dbo.Reminds", new[] { "CycleId" });
            DropIndex("dbo.PrivateMessageReplies", new[] { "MessageId" });
            DropIndex("dbo.PrivateMessages", new[] { "StatusId" });
            DropForeignKey("dbo.Reminds", "StatusId", "dbo.RemindStatus");
            DropForeignKey("dbo.Reminds", "CycleId", "dbo.RemindCycles");
            DropForeignKey("dbo.PrivateMessageReplies", "MessageId", "dbo.PrivateMessages");
            DropForeignKey("dbo.PrivateMessages", "StatusId", "dbo.PrivateMessageStatus");
            DropTable("dbo.RemindStatus");
            DropTable("dbo.RemindCycles");
            DropTable("dbo.Reminds");
            DropTable("dbo.PrivateMessageReplies");
            DropTable("dbo.PrivateMessageStatus");
            DropTable("dbo.PrivateMessages");
            DropTable("dbo.Messages");
            DropTable("dbo.SiteNews");
            DropTable("dbo.ArticleComments");
            DropTable("dbo.Components");
            DropTable("dbo.Users");
            DropTable("dbo.AlbumImages");
            DropTable("dbo.Albums");
            DropTable("dbo.ContactGroups");
            DropTable("dbo.Contacts");
            DropTable("dbo.Twitters");
            DropTable("dbo.RssSources");
            DropTable("dbo.ArticleCategories");
            DropTable("dbo.Articles");
            DropTable("dbo.ArticleTypes");
            DropTable("dbo.MUsers");
        }
    }
}
