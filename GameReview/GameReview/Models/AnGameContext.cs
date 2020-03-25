using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameReview.Models
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

        public System.Data.Entity.DbSet<GameReview.Models.AnGame> AnGames { get; set; }

        public System.Data.Entity.DbSet<GameReview.Models.AnDeveloper> AnDevelopers { get; set; }

        public System.Data.Entity.DbSet<GameReview.Models.AnGenre> AnGenres { get; set; }

        public System.Data.Entity.DbSet<GameReview.Models.AnUser> AnUsers { get; set; }

        public System.Data.Entity.DbSet<GameReview.Models.AnReview> AnReviews { get; set; }
        public System.Data.Entity.DbSet<GameReview.Models.AnReviewReply> AnReviewReplys { get; set; }
        public System.Data.Entity.DbSet<GameReview.Models.AnComment> AnComment { get; set; }
        public System.Data.Entity.DbSet<GameReview.Models.AnCommentReply> AnCommentReplys { get; set; }
    }
}
