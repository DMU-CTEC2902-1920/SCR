using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace GameReview.Models
{
    public class AnGenre
    {
        //declare as primary key
        [Key]
        public virtual int GenreID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}