using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCGamesReviewWebsite.Models
{
    public class Developer
    {

        public virtual int Id { get; set; }
        [Required]
        public virtual string Name { get; set; }
        [StringLength(100)]
        public virtual string Description { get; set; }

    }
}