using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameReviewWebsite.Models
{
    public class AnComment
    {
        [Key]
        public virtual int CommentId { get; set; }
        public virtual string CommentText { get; set; }

        public virtual int UserId { get; set; }

        public virtual AnUser CommentedBy { get; set; }
    }
}