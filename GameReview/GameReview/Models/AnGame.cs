using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameReview.Models
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
        public virtual int DeveloperId { get; set; }
        public virtual AnGenre Genre { get; set; }
        public virtual int GenreID { get; set; }

        public virtual int? ReviewId { get; set; }
        public virtual ICollection<AnReview> ListReview { get; set; }

        //public virtual List<AnReviewReply> ListReviewReply { get; set; }
        //public virtual int ReviewReplyId { get; set; }
    }
}