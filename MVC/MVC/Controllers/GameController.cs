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
        //this is a simple example of an action method
        //that acceps some data from a HTTP GET request
        public string AnGame(int Id, string Genre, string Platform,  string Price)
        {
            //return "Game: Id = " + id.ToString();

            //To try out the code below, use his url
            //localhost:3552/Game/AnGame?Id=1&Genre=Action&Platform=Pc&Price=12
            return String.Format("Game ID = {0}, Genre={1}, Platform={2}, Price={3}", Id, Genre, Platform, Price);
        }
    }
}