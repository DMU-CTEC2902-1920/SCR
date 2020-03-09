using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC.Controllers;
using MVC.Models;

namespace MVC.Tests.Controllers
{
    [TestClass]
    public class GameControllerTest
    {
        [TestMethod]
        public void IndexWelcomeMessage()
        {
            // Arrange
            GameController controller = new GameController();

            // Act

            ViewResult result = controller.Index();
            // Assert
            Assert.AreEqual("Welcome to the game reviews! Please leave a review!",
           controller.ViewBag.WelcomeMessage);
        }
        [TestMethod]
        public void GameName()
        {
            // Arrange
            GameController controller = new GameController();
            // Act
            ViewResult viewResult = controller.AnGame();
            AnGameModel result = viewResult.Model as AnGameModel;
            // Assert
            Assert.AreEqual("Minecraft", result.Name);
        }



    }
}
