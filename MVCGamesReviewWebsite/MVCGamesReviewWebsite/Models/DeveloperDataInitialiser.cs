using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace MVCGamesReviewWebsite.Models
{
    public class DeveloperDataInitialiser : DropCreateDatabaseAlways<DeveloperContext>

    {
        protected override void Seed(DeveloperContext context)
        {

            Developer del1 = new Developer();
            del1.Id = 1;
            del1.Name = "George";
            del1.Description = "Great Developer";
            Developer del2 = new Developer();
            del1.Id = 2;
            del1.Name = "Micheal";
            del1.Description = "Good  Developer";
            base.Seed(context);

    }   }
        
    
}