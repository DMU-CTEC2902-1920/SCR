using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using MVC.Models;
using System.Linq;

namespace MVC.Controllers
{
    public class DeveloperController : Controller
    {

        private List<Developer> _developers = new List<Developer>()
        {
            new Developer
            {   DeveloperId = 1,
                Name = "John",
                Description = "Upcoming developer!",
                Platform = "PC",
                Rating = 0.1m},
            new Developer
            {   DeveloperId = 2,
                Name = "Steve",
                Description = "Good developer!",
                Platform = "PC",
                Rating = 0.1m},
            new Developer
            {   DeveloperId = 3,
                Name = "Jake",
                Description = "Great developer!",
                Platform = "PC",
                Rating = 0.1m}

        };
        // GET: Developer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Details/id
        public ActionResult Details(int? id)
        {

           

        }
    }
}