using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace GameReviewWebsite.Models
{
    public class AnGenre
    {
        [Key]
        public virtual int GenreID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}