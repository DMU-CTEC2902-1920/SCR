using System;
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
            AnGame game1 = new AnGame();
            game1.Id = 1;
            game1.GenreId = 1;
            game1.Name = "Minecraft";
            game1.Description = "Lots of fun";
            game1.Genre = gen1;
            game1.Platform = "PC";
            game1.Price= 100m;
            context.AnGames.Add(game1);
            AnGame game2 = new AnGame();
            game2.Id = 1;
            game2.GenreId = 1;
            game2.Name = "Rust";
            game2.Description = "Infuriating!";
            game2.Genre = gen2;
            game2.Platform = "PC";
            game2.Price = 200m;
            context.AnGames.Add(game2);

            base.Seed(context);

        }
    }
}