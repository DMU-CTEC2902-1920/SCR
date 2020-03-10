using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCGamesReviewWebsite.Models
{
    public class AnGame
    {
        public virtual int Id { get; set; }
        public virtual int GenreId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual string Platform { get; set; }
        public virtual decimal Price { get; set; }
    }
}