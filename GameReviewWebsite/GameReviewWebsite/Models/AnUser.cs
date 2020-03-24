using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameReviewWebsite.Models
{
    public class AnUser
    {
        [Key]
        public virtual int UserId { get; set; }

        public virtual string Password { get; set; }

        public virtual string Email { get; set; }
    }
}