using System;
using System.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleNet.Infrastructure.Persistence;
using BubbleNet.Core;
using BubbleNet.Controllers;
using System.Web.Mvc;
using System.Net;
using BubbleNet.Core.Models;

namespace BubbleNet.Test.Web.Controllers
{
    [TestClass]
    public class ProjectControllerTest
    {

        private ProjectController _controller;
        public ProjectControllerTest()
        {
            IUnitOfWork uow = new UnitOfWork();
            _controller = new ProjectController(uow);
        }

        [TestMethod]
        public void IndexTest()
        {
            var result = _controller.Index() as ViewResult;
            Assert.AreEqual("Index", result.ViewName);
        }

        [TestMethod]
        public void DetailsTest()
        {
            var result = _controller.Details(null) as HttpStatusCodeResult;
            Assert.AreEqual( (int) HttpStatusCode.BadRequest , result.StatusCode);

            result = _controller.Details(long.MaxValue) as HttpNotFoundResult;
            Assert.AreEqual((int)HttpStatusCode.NotFound, result.StatusCode);

            ViewResult vr = _controller.Details(1) as ViewResult;
            if (vr != null)
                Assert.AreEqual("Details", vr.ViewName);

        }

        [TestMethod]
        public void CreateTest()
        {
            var result = _controller.Create() as ViewResult;
            Assert.AreEqual("Create", result.ViewName);

            Project project = new Project { ProjectName="UnitTest", Discription = "Test And Test" };
            var rr = _controller.Create(project) as RedirectToRouteResult;

            Assert.AreEqual(string.Empty, rr.RouteName);
        }

        [TestMethod]
        public void EditTest()   
        {
             long? num = null;
            var result = _controller.Edit(num) as HttpStatusCodeResult;
            Assert.AreEqual( (int) HttpStatusCode.BadRequest , result.StatusCode);

            result = _controller.Edit(long.MaxValue) as HttpNotFoundResult;
            Assert.AreEqual((int)HttpStatusCode.NotFound, result.StatusCode);

            ViewResult vr = _controller.Edit(1) as ViewResult;
            if (vr != null)
                Assert.AreEqual("Edit", vr.ViewName);

            Project project = new Project { ProjectId = 1, ProjectName = "UnitTest", Discription = "Test And Test" };
            var rr = _controller.Edit(project) as RedirectToRouteResult;
            Assert.AreEqual(string.Empty, rr.RouteName);
        }

        public void DeleteTest()
        {
            var result = _controller.Delete(null) as HttpStatusCodeResult;
            Assert.AreEqual((int)HttpStatusCode.BadRequest, result.StatusCode);

            result = _controller.Delete(long.MaxValue) as HttpNotFoundResult;
            Assert.AreEqual((int)HttpStatusCode.NotFound, result.StatusCode);

            ViewResult vr = _controller.Delete(1) as ViewResult;
            if (vr != null)
                Assert.AreEqual("Delete", vr.ViewName);
        }
    }
}
