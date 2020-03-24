using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameReviewWebsite.Models
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


        public System.Data.Entity.DbSet<GameReviewWebsite.Models.AnGame> AnGames { get; set; }
        public System.Data.Entity.DbSet<GameReviewWebsite.Models.AnDeveloper> AnDevelopers { get; set; }
        public System.Data.Entity.DbSet<GameReviewWebsite.Models.AnGenre> AnGenres { get; set; }
        public System.Data.Entity.DbSet<GameReviewWebsite.Models.AnReview> AnReviews { get; set; }
        public System.Data.Entity.DbSet<GameReviewWebsite.Models.AnReviewReply> AnReviewReplys { get; set; }
        public System.Data.Entity.DbSet<GameReviewWebsite.Models.AnComment> AnComments { get; set; }
        public System.Data.Entity.DbSet<GameReviewWebsite.Models.AnCommentReply> AnCommentReplys { get; set; }
        public System.Data.Entity.DbSet<GameReviewWebsite.Models.AnUser> AnUsers { get; set; }
    }
}
