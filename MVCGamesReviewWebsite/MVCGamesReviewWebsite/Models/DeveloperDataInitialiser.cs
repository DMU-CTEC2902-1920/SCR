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

            Developer dev1 = new Developer();
            dev1.Id = 1;
            dev1.Name = "George";
            dev1.Description = "Great Developer";
            context.Developers.Add(dev1);


            Developer dev2 = new Developer();
            dev2.Id = 2;
            dev2.Name = "Micheal";
            dev2.Description = "Good Developer";
            context.Developers.Add(dev2);

            base.Seed(context);

    }   }
        
    
}