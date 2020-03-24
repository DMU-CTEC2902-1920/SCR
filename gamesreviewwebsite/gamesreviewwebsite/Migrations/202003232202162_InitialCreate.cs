namespace gamesreviewwebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AnDevelopers",
                c => new
                    {
                        DeveloperId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        GameId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeveloperId);
            
            CreateTable(
                "dbo.AnGames",
                c => new
                    {
                        GameId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Platform = c.String(),
                        ImgSrc = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeveloperId = c.Int(nullable: false),
                        GenreID = c.Int(nullable: false),
                        ReviewId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GameId)
                .ForeignKey("dbo.AnDevelopers", t => t.DeveloperId, cascadeDelete: true)
                .ForeignKey("dbo.AnGenres", t => t.GenreID, cascadeDelete: true)
                .Index(t => t.DeveloperId)
                .Index(t => t.GenreID);
            
            CreateTable(
                "dbo.AnGenres",
                c => new
                    {
                        GenreID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.GenreID);
            
            CreateTable(
                "dbo.AnReviews",
                c => new
                    {
                        ReviewId = c.Int(nullable: false, identity: true),
                        ReviewText = c.String(),
                        UserId = c.Int(nullable: false),
                        AnGame_GameId = c.Int(),
                    })
                .PrimaryKey(t => t.ReviewId)
                .ForeignKey("dbo.AnUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AnGames", t => t.AnGame_GameId)
                .Index(t => t.UserId)
                .Index(t => t.AnGame_GameId);
            
            CreateTable(
                "dbo.AnUsers",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Password = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AnReviews", "AnGame_GameId", "dbo.AnGames");
            DropForeignKey("dbo.AnReviews", "UserId", "dbo.AnUsers");
            DropForeignKey("dbo.AnGames", "GenreID", "dbo.AnGenres");
            DropForeignKey("dbo.AnGames", "DeveloperId", "dbo.AnDevelopers");
            DropIndex("dbo.AnReviews", new[] { "AnGame_GameId" });
            DropIndex("dbo.AnReviews", new[] { "UserId" });
            DropIndex("dbo.AnGames", new[] { "GenreID" });
            DropIndex("dbo.AnGames", new[] { "DeveloperId" });
            DropTable("dbo.AnUsers");
            DropTable("dbo.AnReviews");
            DropTable("dbo.AnGenres");
            DropTable("dbo.AnGames");
            DropTable("dbo.AnDevelopers");
        }
    }
}