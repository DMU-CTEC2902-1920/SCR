using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReview.Models
{
    public class AnReview
    {
        //declare as primary key
        [Key]
        public virtual int ReviewId { get; set; }
        public virtual string ReviewText { get; set; }
        public virtual int ReviewScore { get; set; }
        public virtual int UserId { get; set; }

        //declare user as a foreign key as a review is left by a user
        [ForeignKey("UserId")]
        public virtual AnUser AnUser { get; set; }

        //declare a list of replies as each review may have multiple replies
        public virtual List<AnReviewReply> ReviewReplies { get; set; }
    }
}