using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleNet.Controllers;
using BubbleNet.Core;
using BubbleNet.Infrastructure.Persistence;

namespace BubbleNet.Test.Web.Controllers
{
    [TestClass]
    public class AppControllerTest
    {
        private AppController _controller;
        public AppControllerTest()
        {
            IUnitOfWork uow = new UnitOfWork();
            _controller = new AppController(uow);
        }
        [TestMethod]
        public void ROITest()
        {
            var result = _controller.ROI() as  ViewResult;
            Assert.AreEqual("ROI", result.ViewName);
        }

        [TestMethod]
        public void PosterTest()
        {
            var result = _controller.Poster(null) as ViewResult;
            Assert.AreEqual("Poster", result.ViewName);
        }
    }
}
