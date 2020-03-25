namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class angamereviewidedited : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AnGames", "ReviewId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AnGames", "ReviewId", c => c.Int(nullable: false));
        }
    }
}
