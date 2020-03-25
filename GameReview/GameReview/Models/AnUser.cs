using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace GameReview.Models
{
    public class AnUser
    {
        //declare as primary key
        [Key]
        public virtual int UserId { get; set; }

        public virtual string Password { get; set; }
        [EmailAddress]
        public virtual string Email { get; set; }
    }
}