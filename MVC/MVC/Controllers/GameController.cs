using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class GameController : Controller
    {

        private AnGameModel _model;
        public GameController() { }

        public GameController(AnGameModel model)
        {
            _model = model;
        }


        // GET: Game
        public ViewResult Index()
        {
            //adding data to the viewbag
            ViewBag.Title = "The Games";
            ViewBag.WelcomeMessage = "Welcome to the game reviews! Please leave a review!";

            return View();
        }

        //method for an game
        //this is a simple example of an action method
        //that acceps some data from a HTTP GET request
        public ViewResult AnGame()

        //localhost:3552/Game/AnGame?Id=1&Name=Minecraft&Genre=Action&Platform=PC&Price=12&Descripion=Test

        {
            //if (_model == null)
            //{
            //    _model = new AnGameModel();
            //    _model.Id = 1;
            //    _model.Name = "Minecraft";
            //    _model.Genre = "Action";
            //    _model.Platform = "PC";
            //    _model.Price = "£12";
            //    _model.Description = "Test Description";
            //}

            ViewBag.Title = _model.Name;

            if (_model.Platform == "PC")
            {
                ViewBag.SubTitle = "Available On PC";
            }
            else if (_model.Platform == "PlayStation")
            {
                ViewBag.SubTitle = "Available On PlayStation";
            }
            else if (_model.Platform == "Xbox")
            {
                ViewBag.SubTitle = "Available On Xbox";
            }
            else if (_model.Platform == "Nintendo Switch")
            {
                ViewBag.SubTitle = "Available On Nintendo Switch";
            }
            else
            {
                ViewBag.SubTitle = "Platform Unknown";
            }
            return View(_model);
        }
    }
}