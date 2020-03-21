using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameReviewWebsite.Models
{
    public class AnGame
    {
        [Key]
        public virtual int GameId { get; set; }
        public virtual string Name { get; set; }
      
        public virtual string Description { get; set; }
        public virtual string Platform { get; set; }
        public string ImgSrc { get; set; }
        public virtual decimal Price { get; set; }

        public virtual AnDeveloper DevelopedBy { get; set; }
        public virtual AnGenre Genre { get; set; }
        public virtual List<AnReview> ListReview { get; set; }
        public virtual int GenreId { get; set; }
    }
}