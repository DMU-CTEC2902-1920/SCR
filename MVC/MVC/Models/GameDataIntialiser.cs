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
            game1.GameId = 1;
            game1.GenreId = 1;
            game1.Name = "Minecraft";
            game1.Description = "Fun for all ages";
            game1.Genre = gen1;
            context.AnGameModel.Add(game1);
            AnGameModel game2 = new AnGameModel();
            game2.GameId = 1;
            game2.GenreId = 1;
            game2.Name = "Rust";
            game2.Description = "Infuriating!";
            game2.Genre = gen2;
            context.AnGameModel.Add(game2);

            base.Seed(context);

        }


    }
}