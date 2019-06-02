using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FirstTestFraemwork.Tests
{
    [TestClass]
    public class GetPageTitle
    {
        [TestMethod]
        public void TestPageTitle()
        {
            string ActualResult;
            string ExpectedResult="Ggle";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            ActualResult = driver.Title;

            if (ActualResult.Contains(ExpectedResult))
            {
                Console.WriteLine("Test case Passed");
            }
            else
            {
                Console.WriteLine("Test case Failed");
            }

            driver.Close();
            driver.Quit();

        }
    }
}
