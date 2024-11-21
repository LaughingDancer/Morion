using app;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestsMorion
{
    [TestClass]
    public class MorionTests
    {
        [TestMethod]
        public void TestAuthorizeUserCorrect()
        {
            string login = "^L5.=FD6(uT?";
            string password = "C<ouj*6u]O])";
            Авторизация authorization = new Авторизация();
            var result = authorization.AuthorizeUser(login, password);
            Assert.IsTrue(result.isAuthorized);
            Assert.IsNotNull(result.position);
            Assert.AreNotEqual(string.Empty, result.position);
        }

        [TestMethod]
        public void TestAuthorizeUserIncorrec()
        {
            string login = "login";
            string password = "password";
            Авторизация authorization = new Авторизация();
            var result = authorization.AuthorizeUser(login, password);
            Assert.IsFalse(result.isAuthorized);
            Assert.AreEqual(string.Empty, result.position);
        }

        [TestMethod]
        public void TestAuthorizeUserIncorrectLogin()
        {
            string login = "incorrectLogin";
            string password = "C<ouj*6u]O])";
            Авторизация authorization = new Авторизация();
            var result = authorization.AuthorizeUser(login, password);
            Assert.IsFalse(result.isAuthorized);
            Assert.AreEqual(string.Empty, result.position);
        }

        [TestMethod]
        public void TestAuthorizeUserIncorrectPassword()
        {
            string login = "L5.=FD6(uT?";
            string password = "incorrectPassword";
            Авторизация authorization = new Авторизация();
            var result = authorization.AuthorizeUser(login, password);
            Assert.IsFalse(result.isAuthorized);
            Assert.AreEqual(string.Empty, result.position);
        }

        [TestMethod]
        public void TestAuthorizeUserNullValues()
        {
            string login = "";
            string password = "";
            Авторизация authorization = new Авторизация();
            var result = authorization.AuthorizeUser(login, password);
            Assert.IsFalse(result.isAuthorized);
            Assert.AreEqual(string.Empty, result.position);
        }
    }
}
