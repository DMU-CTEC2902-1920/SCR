namespace GameReviewWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnCommentReplies",
                c => new
                    {
                        CommentReplyId = c.Int(nullable: false, identity: true),
                        CommentReplyText = c.String(),
                        UserId = c.Int(nullable: false),
                        CommentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentReplyId)
                .ForeignKey("dbo.AnUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AnComments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        UserId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.AnUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnComments", "UserId", "dbo.AnUsers");
            DropForeignKey("dbo.AnCommentReplies", "UserId", "dbo.AnUsers");
            DropIndex("dbo.AnComments", new[] { "UserId" });
            DropIndex("dbo.AnCommentReplies", new[] { "UserId" });
            DropTable("dbo.AnComments");
            DropTable("dbo.AnCommentReplies");
        }
    }
}
