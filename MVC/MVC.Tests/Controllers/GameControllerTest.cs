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

        [TestMethod]
        public void GameIsForPC()
        {
            // Arrange
            GameController controller = new GameController();
            // Act
            ViewResult viewResult = controller.AnGame();
            AnGameModel result = viewResult.Model as AnGameModel;
            // Assert
            Assert.AreEqual("PC", result.Platform);
        }


        //testing  with dependancy injection



        [TestMethod]
        public void GameIsForPlayStation()
        {

            //arange

            AnGameModel model = new AnGameModel();
            model.Id = 1;
            model.Name = "Rust";
            model.Genre = "Action";
            model.Platform = "PC";
            model.Price = "£31";
            model.Description = "Test Description 2";


            //inject the contoller's dependency on the model so we can test it 
            GameController controller = new GameController(model);
            
            
            //Act
            ViewResult result = controller.AnGame();
            Assert.AreEqual("Available On PC", result.ViewBag.SubTitle);
        }
    }
}
