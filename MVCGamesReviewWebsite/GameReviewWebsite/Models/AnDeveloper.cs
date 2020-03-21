using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GameReviewWebsite.Models
{
    public class AnDeveloper
    {
        [Key]
        public virtual int DeveloperId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}