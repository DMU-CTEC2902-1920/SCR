namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedvalidaiton : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AnCommentReplies", "CommentReplyText", c => c.String(nullable: false));
            AlterColumn("dbo.AnComments", "CommentText", c => c.String(nullable: false));
            AlterColumn("dbo.AnReviews", "ReviewText", c => c.String(nullable: false));
            AlterColumn("dbo.AnReviewReplies", "ReviewReplyText", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AnReviewReplies", "ReviewReplyText", c => c.String());
            AlterColumn("dbo.AnReviews", "ReviewText", c => c.String());
            AlterColumn("dbo.AnComments", "CommentText", c => c.String());
            AlterColumn("dbo.AnCommentReplies", "CommentReplyText", c => c.String());
        }
    }
}
