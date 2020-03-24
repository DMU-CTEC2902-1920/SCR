using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GameReview.Models
{
    public class AnCommentReply
    {
        [Key]
        public virtual int CommentReplyId { get; set; }
        public virtual string CommentReplyText { get; set; }
        public virtual int UserId { get; set; }
        public virtual AnUser CommentRepliedBy { get; set; }
        public virtual int CommentId { get; set; }
        [ForeignKey("CommentId")]
        public virtual int CommentComment { get; set; }
    }
}