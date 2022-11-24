using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Selenium_BP.Pages;
using Selenium_BP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_BP
{
    public class TestLogin : TestCase
    {
        private static LoginPage? _loginPage;


        [Test]
        public void ShouldBeSuccessfulLogin()
        {
            _loginPage = new LoginPage(this.driver, 10);
            _loginPage.AwaitPageLoad();
            _loginPage.FillLogin("qa_test");
            _loginPage.FillPassword("n0Y*QMKPV8N");
            _loginPage.ClickLogin();
            Assert.IsNotNull(_loginPage.verifyLoggedIn());
        }

        [Test]
        public void ShouldBeFailedLogin()
        {
            _loginPage = new LoginPage(this.driver, 10);
            _loginPage.AwaitPageLoad();
            _loginPage.FillLogin("qa_test");
            _loginPage.FillPassword("wrong password");
            _loginPage.ClickLogin();
            Assert.AreEqual(_loginPage.verifyLoginError().Text, "Invalid Password: The system is unable to log you in. Ensure that your User ID and Password are correct and please try again.");
        }


    }
}
