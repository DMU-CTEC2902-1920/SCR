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
        [Key]
        public virtual int ReviewReplyId { get; set; }
        [Required]
        public virtual string ReviewReplyText { get; set; }
        public virtual int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AnUser ReviewRepliedBy { get; set; }
        public virtual int ReviewId { get; set; }
        [ForeignKey("ReviewId")]
        public virtual AnReview AnReview { get; set; }
    }
}