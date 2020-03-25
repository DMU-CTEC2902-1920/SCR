using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameReview.Models
{
    public class 
        AnGame
    {
        //declare as primary key
        [Key]
        public virtual int GameId { get; set; }
        public virtual string Name { get; set; }

        public virtual string Description { get; set; }
        public virtual string Platform { get; set; }
        public string ImgSrc { get; set; }
        public virtual decimal Price { get; set; }
        public virtual decimal Score { get; set; }
        public virtual string ReleaseDate { get; set; }

        //declare developer as a foreign key as they develop specific games
        public virtual AnDeveloper DevelopedBy { get; set; }
        public virtual int DeveloperId { get; set; }
        //declare genre as forign key as each game has a specific genre
        public virtual AnGenre Genre { get; set; }
        public virtual int GenreID { get; set; }
        //declare review list and foerign key as a game will have a list of reviews
        public virtual int? ReviewId { get; set; }
        public virtual ICollection<AnReview> ListReview { get; set; }

        //public virtual List<AnReviewReply> ListReviewReply { get; set; }
        //public virtual int ReviewReplyId { get; set; }
    }
}