namespace GameReviewWebsite.Migrations
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
                    })
                .PrimaryKey(t => t.DeveloperId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AnDevelopers");
        }
    }
}
