using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstTestFraemwork
{
    [TestClass]
    public class TradelizeLogin
    {
        [TestMethod]
        public void VerifyTradelizeLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://qa-portal.tradelize.com/");
            LoginPage login = new LoginPage(driver);
            login.TypeUsername();
            login.TypePassword();
            login.ClickOnWelcomeBtn();
            Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
