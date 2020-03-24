namespace gamesreviewwebsite.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using gamesreviewwebsite.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<gamesreviewwebsite.Models.AnGamesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "gamesreviewwebsite.Models.AnGamesContext";
        }

        protected override void Seed(gamesreviewwebsite.Models.AnGamesContext context)
        {
            //developer
            var developers = new List<AnDeveloper>
            {
                new AnDeveloper {DeveloperId=1, Name = "George", Description="A goood developer"}
            };

            developers.ForEach(developer => context.
                                  AnDevelopers.
                                  AddOrUpdate(a => a.DeveloperId, developer));


            context.SaveChanges();


            //User
            var users = new List<AnUser>
            {
                new AnUser {UserId =1, Email="cjs@hotmail.com", Password="Test1!"}
            };

            users.ForEach(user => context.
                                  AnUsers.
                                  AddOrUpdate(b => b.UserId, user));
            context.SaveChanges();
            //genres
            var genres = new List<AnGenre>
            {
                new AnGenre {GenreID=1, Name = "Adventure", Description="Lots of adventure"}
            };

            genres.ForEach(genre => context.
                                  AnGenres.
                                  AddOrUpdate(c => c.GenreID, genre));
            context.SaveChanges();

            //review
            var reviews = new List<AnReview>
            {
                new AnReview {ReviewId =1, ReviewText="Nice game", UserId=1}
            };

            reviews.ForEach(review => context.
                                  AnReviews.
                                  AddOrUpdate(d => d.ReviewId, review));
            context.SaveChanges();



            

            //games

            var games = new List<AnGame>
            {
                new AnGame{GameId=1, Name="Minecraft", Description="Fun", Platform="Pc", ImgSrc="https://media.playstation.com/is/image/SCEA/minecraft-starter-collection-squareboxart-01-ps4-11dec19-en-us?$native_nt$",
                    Price=2, DeveloperId=1, GenreID=1,  ReviewId=1}
            };

            games.ForEach(game => context.
                                  AnGames.
                                  AddOrUpdate(e => e.GameId, game));
            context.SaveChanges();



        }
    }
}
