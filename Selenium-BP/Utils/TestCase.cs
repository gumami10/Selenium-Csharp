using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Selenium_BP.Utils
{
    public class TestCase
    {
        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://security.bplogix.net/");
            driver.Manage().Window.Maximize();
        }
        public IWebDriver driver;

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }


    }
}
