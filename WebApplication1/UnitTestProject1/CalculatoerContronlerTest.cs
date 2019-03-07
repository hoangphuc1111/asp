using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Controllers;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class CalculatoerContronlerTest
    {
        [TestMethod]
        public void TestIndex()
        {
            HomeController contronller = new HomeController();

            ViewResult result = contronller.Index() as ViewResult;

            Assert.IsNotNull(result);

        }
        [TestMethod]

        public void TestAuthor()
        {
            var controller = new CalculatorController();

            var result = controller.ShowAuthor();

            Assert.AreEqual("Cao Le Hoang Phuc", result);
        }

    }
}
