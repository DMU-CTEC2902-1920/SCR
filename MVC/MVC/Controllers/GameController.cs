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
        {
            AnGameModel GameModel = new AnGameModel();
            GameModel.Id = 1;
            GameModel.Name = "Minecraft";
            GameModel.Genre = "Action";
            GameModel.Platform = "PC";
            GameModel.Price = "£12";


            if(GameModel.Platform == "PC")
            {
                ViewBag.SubTitle = "Available On PC";
            }
            else if(GameModel.Platform == "PlayStation")
            {
                ViewBag.SubTitle = "Available On PlayStation";
            }
            else if (GameModel.Platform == "Xbox")
            {
                ViewBag.SubTitle = "Available On Xbox";
            }
            else if (GameModel.Platform == "Nintendo Switch")
            {
                ViewBag.SubTitle = "Available On Nintendo Switch";
            }
            else
            {
                ViewBag.SubTitle = "Platform Unknown";
            }
            return View(GameModel);
    }
}