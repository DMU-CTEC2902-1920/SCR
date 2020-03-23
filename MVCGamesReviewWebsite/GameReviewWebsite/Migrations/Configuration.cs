namespace GameReviewWebsite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Collections.Generic;
    using GameReviewWebsite.Models;
    internal sealed class Configuration : DbMigrationsConfiguration<GameReviewWebsite.Models.AnDevelopersContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GameReviewWebsite.Models.AnDeveloperContext";
        }

        protected override void Seed(GameReviewWebsite.Models.AnDevelopersContext context)
        {
            //  This method will be called after migrating to the latest version.
            var developers = new List<AnDeveloper>
            {
                new AnDeveloper {DeveloperId=1, Name = "George", Description="A goood developer"}
            };

            developers.ForEach(developer => context.
                                  AnDevelopers.
                                  AddOrUpdate(p => p.Description, developer));
            context.SaveChanges();
            
        }
    }
}
