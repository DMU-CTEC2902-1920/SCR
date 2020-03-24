using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace GameReviewWebsite.Models
{
    public class AnReviewReply
    {
        [Key]
        public virtual int ReviewReplyId { get; set; }
        public virtual string ReviewReplyText { get; set; }

        public virtual int UserId { get; set; }
        public virtual int ReviewId { get; set; }
        public virtual AnUser ReviewedBy { get; set; }
    }
}