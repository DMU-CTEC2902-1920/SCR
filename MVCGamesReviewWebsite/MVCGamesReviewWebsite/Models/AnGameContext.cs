using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MVCGamesReviewWebsite.Models;
namespace MVCGamesReviewWebsite.Models
{
    public class AnGameContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public AnGameContext() : base("name=AnGameContext")
        {
        }

        public DbSet<AnGame> AnGames { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Developer> Developers { get; set; }
        

     
    }
}
