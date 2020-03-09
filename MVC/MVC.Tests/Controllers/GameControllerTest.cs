using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC.Controllers;

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
            Assert.AreEqual("Welcome to the shop. Kindly spend all your money!",
           controller.ViewBag.WelcomeMessage);
        }

     
    }
}
