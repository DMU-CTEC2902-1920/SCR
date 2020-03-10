using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC.Models
{
    
    public class AnGameModel
    {
       
        public virtual int Id { get; set; }
        public virtual int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual string Platform { get; set; }
        public virtual string Price { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
    }
   
}
