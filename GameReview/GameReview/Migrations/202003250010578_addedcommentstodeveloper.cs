namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcommentstodeveloper : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnComments",
                c => new
                    {
                        CommentId = c.Int(nullable: false, identity: true),
                        CommentText = c.String(),
                        UserId = c.Int(nullable: false),
                        AnDeveloper_DeveloperId = c.Int(),
                    })
                .PrimaryKey(t => t.CommentId)
                .ForeignKey("dbo.AnUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AnDevelopers", t => t.AnDeveloper_DeveloperId)
                .Index(t => t.UserId)
                .Index(t => t.AnDeveloper_DeveloperId);
            
            CreateTable(
                "dbo.AnCommentReplies",
                c => new
                    {
                        CommentReplyId = c.Int(nullable: false, identity: true),
                        CommentReplyText = c.String(),
                        UserId = c.Int(),
                        CommentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CommentReplyId)
                .ForeignKey("dbo.AnComments", t => t.CommentId, cascadeDelete: true)
                .ForeignKey("dbo.AnUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.CommentId);
            
            AddColumn("dbo.AnDevelopers", "CommentId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnComments", "AnDeveloper_DeveloperId", "dbo.AnDevelopers");
            DropForeignKey("dbo.AnCommentReplies", "UserId", "dbo.AnUsers");
            DropForeignKey("dbo.AnCommentReplies", "CommentId", "dbo.AnComments");
            DropForeignKey("dbo.AnComments", "UserId", "dbo.AnUsers");
            DropIndex("dbo.AnCommentReplies", new[] { "CommentId" });
            DropIndex("dbo.AnCommentReplies", new[] { "UserId" });
            DropIndex("dbo.AnComments", new[] { "AnDeveloper_DeveloperId" });
            DropIndex("dbo.AnComments", new[] { "UserId" });
            DropColumn("dbo.AnDevelopers", "CommentId");
            DropTable("dbo.AnCommentReplies");
            DropTable("dbo.AnComments");
        }
    }
}
