using OpenQA.Selenium;
using Selenium_BP.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_BP.Pages
{
    public class LoginPage
    {
        IWebDriver driver;
        int waitTime;
        public LoginPage(IWebDriver driver, int waitTime) 
        {
            this.driver = driver;
            this.waitTime = waitTime;
        }


        public void AwaitPageLoad()
        {
            this.driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_sLogoURL"), this.waitTime);
        }

        public void FillLogin(String login)
        {
            this.driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_UserID"), this.waitTime).SendKeys(login);
        }

        public void FillPassword(String password)
        {
            this.driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_Password"), this.waitTime).SendKeys(password);
        }

        public void ClickLogin()
        {
            this.driver.FindElement(By.Id("ctl00_ContentPlaceHolder2_OK_TextArea"), this.waitTime).Click();
        }

        public IWebElement verifyLoggedIn()
        {
            this.driver.FindElement(By.Id("btn_slide_out"), this.waitTime).Click();
            return this.driver.FindElement(By.Id("UserInfoPanel"), this.waitTime);
        }

        public IWebElement verifyLoginError()
        {
            return this.driver.FindElement(By.ClassName("bpErrorText"), this.waitTime);
        }
    }
}
