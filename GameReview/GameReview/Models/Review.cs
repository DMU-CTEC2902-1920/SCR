using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGamesReviewWebsite.Models
{
    public class Review
    {
        public virtual int ReviewId { get; set; }
        public virtual string ReviewText { get; set; }

        public virtual int UserId { get; set; }

        public virtual User ReviewedBy { get; set; }
    }
}