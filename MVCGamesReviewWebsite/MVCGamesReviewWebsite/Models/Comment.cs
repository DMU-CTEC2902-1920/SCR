using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGamesReviewWebsite.Models
{
    public class Comment
    {
        public int CommentId { get; set; }

        public int UserId { get; set; }
        public String Text { get; set; }

        

        public virtual User User { get; set; }
    }
}