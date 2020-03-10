using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    public class Genre
    {
        //declared virtual so can be overidden
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
}