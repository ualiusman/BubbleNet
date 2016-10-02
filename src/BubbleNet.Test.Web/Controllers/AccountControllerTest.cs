using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BubbleNet.Controllers;
using BubbleNet.Infrastructure.Persistence;
using BubbleNet.Core;
using System.Web.Mvc;

namespace BubbleNet.Test.Web.Controllers
{
    [TestClass]
    public class AccountControllerTest
    {
        private AccountController _controller;
        public AccountControllerTest()
        {
            IUnitOfWork uow = new UnitOfWork();
            _controller = new AccountController(uow);
        }
        [TestMethod]
        public void LoginTest()
        {
            var result = _controller.Login(null) as ViewResult;
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void RegisterTest()
        {
            var result = _controller.Register() as ViewResult;
            Assert.IsNotNull(result);
        }
    }
}
