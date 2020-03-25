namespace GameReview.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GameReview.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<GameReview.Models.AnGameContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GameReview.Models.AnGameContext context)
        {
            //developer
            var developers = new List<AnDeveloper>
            {
                new AnDeveloper {DeveloperId=2, Name = "George", Description="A goood developer"},
                new AnDeveloper {DeveloperId=3, Name = "Steve", Description="A Okay developer"},
                new AnDeveloper {DeveloperId=4, Name = "Micheal", Description="A decent developer"},
                new AnDeveloper {DeveloperId=5, Name = "John", Description="A bad developer"}

            };
            developers.ForEach(developer => context.
                                  AnDevelopers.
                                  AddOrUpdate(a => a.DeveloperId, developer));


            context.SaveChanges();






            //User
            var users = new List<AnUser>
            {
                new AnUser {UserId =2, Email="cjs@hotmail.com", Password="Test1!"},
                new AnUser {UserId =3, Email="pjs@hotmail.com", Password="Test2!"},
                new AnUser {UserId =4, Email="ljs@hotmail.com", Password="Test3!"},
                new AnUser {UserId =5, Email="mjs@hotmail.com", Password="Test4!"}
            };

            users.ForEach(user => context.
                                  AnUsers.
                                  AddOrUpdate(b => b.UserId, user));
            context.SaveChanges();

            //genre
            var genres = new List<AnGenre>
            {
                new AnGenre {GenreID =2, Name="Adventure", Description="lots of adventure" },
                new AnGenre {GenreID =3, Name="RPG", Description="lots of roleplay" },
                new AnGenre {GenreID =4, Name="MMO", Description="lots of multiplayer" }
                
            };

            genres.ForEach(genre => context.
                                  AnGenres.
                                  AddOrUpdate(b => b.GenreID, genre));
            context.SaveChanges();

            var games = new List<AnGame>
            {
                new AnGame{GameId=1, Name="Rust", Description="Infuriating", Platform="Pc", ImgSrc="data:image/jpeg;base64,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",
                    Price=2, DeveloperId=2, GenreID=1, ReviewId=null}
               
            };

            games.ForEach(game => context.
                                  AnGames.
                                  AddOrUpdate(e => e.GameId, game));
            context.SaveChanges();

        }
    }
}
