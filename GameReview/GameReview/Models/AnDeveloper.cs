using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace GameReview.Models
{
    public class AnDeveloper
    {
        //declare as primary key
        [Key]
        public virtual int DeveloperId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual int GameId { get; set; }
        //declare list of games the developer has made
        public virtual List<AnGame> GamesDeveloped { get; set; }
        //declare list of comments for the developer as comments can be left for developers
        public virtual int CommentId { get; set; }
        public virtual ICollection<AnComment> ListComment { get; set; }
    }
}