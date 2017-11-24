using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SomeAPI;
using SomeAPI.Controllers;

namespace SomeAPI.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTestd
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
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
