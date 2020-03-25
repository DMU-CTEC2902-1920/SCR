using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameReview.Models
{
    public class AnComment
    {
        //declare comment as primary key
        [Key]
        public virtual int CommentId { get; set; }
        public virtual string CommentText { get; set; }
        public virtual int UserId { get; set; }
        
        //declare user as a foreign key
        [ForeignKey("UserId")]
        public virtual AnUser AnUser { get; set; }
        public virtual List<AnCommentReply> CommentReplies { get; set; }
    }
}