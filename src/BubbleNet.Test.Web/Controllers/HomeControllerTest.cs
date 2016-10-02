using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleNet.Controllers;
using System.Web.Mvc;

namespace BubbleNet.Test.Web.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void IndexTest()
        {
            var controller = new HomeController();
            var result = controller.Index() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
