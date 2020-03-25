namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatemodel : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.AnReviews", new[] { "AnGame_GameId1" });
            DropColumn("dbo.AnReviews", "AnGame_GameId");
            RenameColumn(table: "dbo.AnReviews", name: "AnGame_GameId1", newName: "AnGame_GameId");
            AlterColumn("dbo.AnReviews", "AnGame_GameId", c => c.Int());
            CreateIndex("dbo.AnReviews", "AnGame_GameId");
        }
        
        public override void Down()
        {
            DropIndex("dbo.AnReviews", new[] { "AnGame_GameId" });
            AlterColumn("dbo.AnReviews", "AnGame_GameId", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.AnReviews", name: "AnGame_GameId", newName: "AnGame_GameId1");
            AddColumn("dbo.AnReviews", "AnGame_GameId", c => c.Int(nullable: false));
            CreateIndex("dbo.AnReviews", "AnGame_GameId1");
        }
    }
}
