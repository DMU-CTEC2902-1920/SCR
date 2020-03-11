﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCGamesReviewWebsite.Models
{
    public class AnGameDataInitialiser : DropCreateDatabaseAlways<AnGameContext>

    {
        protected override void Seed(AnGameContext context)
        {


            Genre gen1 = new Genre();
            gen1.GenreId = 1;
            gen1.Name = "Action";
            gen1.Description = "Action paced fun!";
            context.Genres.Add(gen1);

            Genre gen2 = new Genre();
            gen2.GenreId = 2;
            gen2.Name = "Action";
            gen2.Description = "Action paced fun!";
            context.Genres.Add(gen2);

            Developer dev1 = new Developer();
            dev1.DeveloperID = 1;
            dev1.Name = "George";
           
            dev1.Description = "Great Developer";
            context.Developers.Add(dev1);


            Developer dev2 = new Developer();
            dev2.DeveloperID = 2;
            dev2.Name = "Micheal";
            
            dev2.Description = "Good Developer";
            context.Developers.Add(dev2);

            Developer dev3 = new Developer();
            dev2.DeveloperID = 3;
            dev2.Name = "Steve";

            dev2.Description = "Ok Developer";
            context.Developers.Add(dev2);

            AnGame game1 = new AnGame();
            game1.Id = 1;
            game1.GenreId = 1;
            game1.Name = "Minecraft";
            game1.DevelopedBy = dev1;
            game1.Description = "Lots of fun";
            game1.Genre = gen1;
            game1.Platform = "PC";
            game1.Price= 10m;
            context.AnGames.Add(game1);

            AnGame game2 = new AnGame();
            game2.Id = 2;
            game2.GenreId = 1;
            game2.Name = "Rust";
            game2.DevelopedBy = dev2;
            game2.Description = "Infuriating!";
            game2.Genre = gen2;
            game2.Platform = "PC";
            game2.Price = 200m;
            context.AnGames.Add(game2);

            AnGame game3 = new AnGame();
            game3.Id = 2;
            game3.GenreId = 1;
            game3.Name = "Rust";
            game3.DevelopedBy = dev3;
            game3.Description = "Infuriating!";
            game3.Genre = gen2;
            game3.Platform = "PC";
            game3.Price = 200m;
            context.AnGames.Add(game3);


           

            

            base.Seed(context);

        }
    }
}