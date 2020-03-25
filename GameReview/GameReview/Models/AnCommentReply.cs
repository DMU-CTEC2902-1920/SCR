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
        //declare as primary key
        [Key]
        public virtual int CommentReplyId { get; set; }
        public virtual string CommentReplyText { get; set; }
        //declare user as a foreign key
        public virtual int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AnUser ReviewRepliedBy { get; set; }

        //declare reply as a foreign key
        public virtual int CommentId { get; set; }
        [ForeignKey("CommentId")]
        public virtual  AnComment AnComment { get; set; }
    }
}