using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameReviewWebsite.Models
{
    public class AnCommentReply
    {
        [Key]
        public virtual int CommentReplyId { get; set; }
        public virtual string CommentReplyText { get; set; }

        public virtual int UserId { get; set; }
        public virtual int CommentId { get; set; }

        public virtual AnUser CommentRepliedBy { get; set; }
    }
}