using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstTestFraemwork
{
    [TestFixture]
    public class UnitTest1
    {
        public IWebDriver driver;

        [SetUp]
        public void init()
        {
            driver = new ChromeDriver();
        }

        [Test]
        public void NavigatetoGoogle()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
