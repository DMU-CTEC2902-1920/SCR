using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameReviewWebsite.Models
{
    public class AnReview
    {
        [Key]
        public virtual int ReviewId { get; set; }
        public virtual string ReviewText { get; set; }

        public virtual int UserId { get; set; }

        public virtual AnUser ReviewedBy { get; set; }
    }
}