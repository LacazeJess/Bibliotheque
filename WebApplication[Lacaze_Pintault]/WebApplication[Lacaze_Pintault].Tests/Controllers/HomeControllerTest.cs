using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication_Lacaze_Pintault_;
using WebApplication_Lacaze_Pintault_.Controllers;

namespace WebApplication_Lacaze_Pintault_.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Auteurs_Abonnees()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Auteurs_Abonnes() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Emprunts()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Emprunts() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
