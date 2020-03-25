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



        }
    }
}
