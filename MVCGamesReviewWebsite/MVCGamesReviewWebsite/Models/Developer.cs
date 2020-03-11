﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCGamesReviewWebsite.Models
{
    public class Developer
    {

        public virtual int DeveloperID { get; set; }
        //public virtual List<AnGame> WorkedOnGames { get; set; }

     
        public virtual string Name { get; set; }
        
        public virtual string Description { get; set; }

    }
}