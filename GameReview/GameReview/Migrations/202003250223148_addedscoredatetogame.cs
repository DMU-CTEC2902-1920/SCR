namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedscoredatetogame : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AnGames", "Score", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.AnGames", "ReleaseDate", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AnGames", "ReleaseDate");
            DropColumn("dbo.AnGames", "Score");
        }
    }
}
