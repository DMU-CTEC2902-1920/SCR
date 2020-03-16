using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGamesReviewWebsite.Models
{
    public class User
    {
        public virtual int UserId { get; set; }
        public virtual int ReviewId { get; set; }
        public virtual Review ReviewedOn { get; set; }
        public virtual string Password { get; set; }

        public virtual string Email { get; set; }

      
    }
}