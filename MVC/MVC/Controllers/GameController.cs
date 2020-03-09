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
        public string Index()
        {
            return "Game Index";
        }
        
        //method for an game
        public string AnGame(int id)
        {
            return "Game: Id = " + id.ToString();
        }
    }
}