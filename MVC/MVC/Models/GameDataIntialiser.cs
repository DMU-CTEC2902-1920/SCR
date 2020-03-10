using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVC.Models
{
    public class GameDataIntialiser: DropCreateDatabaseAlways<AnGameContext>
    {

        protected override void Seed(AnGameContext context)
        {
            Genre gen1 = new Genre();
            gen1.GenreId = 1;
            gen1.Name = "Action";
            gen1.Description = "Action packed fun";
            context.Genres.Add(gen1);
            Genre gen2 = new Genre();
            gen2.GenreId = 2;
            gen2.Name = "Role-Playing";
            gen2.Description = "Role-playing fun";
            context.Genres.Add(gen2);
            AnGameModel game1 = new AnGameModel();
            game1.Id = 1;
            game1.GenreId = 1;
            game1.Genre = gen1;
            game1.Platform = "PC";
            game1.Price = "£12";
            game1.Name = "Minecraft";
            game1.Description = "Fun for all ages";
           
            context.AnGameModels.Add(game1);
            AnGameModel game2 = new AnGameModel();
            game2.Id = 1;
            game2.GenreId = 1;
            game2.Genre = gen1;
            game2.Platform = "PC";
            game2.Price = "£12";
            game2.Name = "Rust";
            game2.Description = "Infuriating!";
            context.AnGameModels.Add(game2);

            base.Seed(context);

        }


    }
}