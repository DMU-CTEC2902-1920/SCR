namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedreviewscoretoanreview : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AnReviews", "ReviewScore", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AnReviews", "ReviewScore");
        }
    }
}
