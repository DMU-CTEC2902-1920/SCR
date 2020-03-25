using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReview.Models
{
    public class AnReviewReply
    {
        //declare as primary key
        [Key]
        public virtual int ReviewReplyId { get; set; }
        public virtual string ReviewReplyText { get; set; }
        public virtual int? UserId { get; set; }
        //declare user as a foreign key as a a reply is made by a specifc user
        [ForeignKey("UserId")]
        public virtual AnUser ReviewRepliedBy { get; set; }

        //declare a review as a foreign key as a reply is for a review
        public virtual int ReviewId { get; set; }
        [ForeignKey("ReviewId")]
        public virtual AnReview AnReview { get; set; }
    }
}