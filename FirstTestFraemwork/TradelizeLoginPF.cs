using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FirstTestFraemwork
{
    [TestClass]
    public class TradelizeLoginPF
    {
        [TestMethod]
        public void VerifyTradelizeLogin()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://qa-portal.tradelize.com/auth");
            LoginPagePF loginPF = new LoginPagePF();
            PageFactory.InitElements(driver, loginPF);
            loginPF.userlogin.SendKeys("tqav3");
            loginPF.userPassword.SendKeys("12345");
            loginPF.btnWelcome.Click();
            Thread.Sleep(5000);
            driver.Quit();

        }
    }
}
