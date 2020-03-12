using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCGamesReviewWebsite.Models
{
    public class AnGame
    {
        public virtual int Id { get; set; }
       
        public virtual int GenreId { get; set; }

        public virtual Developer DevelopedBy { get; set; }

        [Required]  
        public virtual string Name { get; set; }
        [StringLength(100)]
        public virtual string Description { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual string Platform { get; set; }
        
        public string ImgSrc { get; set; }
        [Range(typeof(decimal), "0.01", "200.00")]
        public virtual decimal Price { get; set; }
    }
}