namespace SmartMe.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Author = c.String(),
                        ISBN = c.String(),
                        Published = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Blogs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Url = c.String(),
                        Rating = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Content = c.String(),
                        BlogId = c.Int(nullable: false),
                        Blog_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Blogs", t => t.BlogId)
                .ForeignKey("dbo.Blogs", t => t.Blog_Id)
                .Index(t => t.BlogId)
                .Index(t => t.Blog_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "Blog_Id", "dbo.Blogs");
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "Blog_Id" });
            DropIndex("dbo.Posts", new[] { "BlogId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Blogs");
            DropTable("dbo.Books");
        }
    }
}
