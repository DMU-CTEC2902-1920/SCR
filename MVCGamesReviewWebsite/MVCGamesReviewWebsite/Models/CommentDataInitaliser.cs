using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MVCGamesReviewWebsite.Models
{
    public class CommentDataInitaliserr : DropCreateDatabaseAlways<CommentContext>
    {
        protected override void Seed(CommentContext context)
        {
            Comment com1 = new Comment();
           
            base.Seed(context);
        }

    }
}