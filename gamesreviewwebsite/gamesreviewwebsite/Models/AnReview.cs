using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace gamesreviewwebsite.Models
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