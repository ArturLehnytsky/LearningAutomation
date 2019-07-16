using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;

namespace FirstTestFraemwork
{
    [TestClass]
    public class FirstTestClass
    {

        [TestMethod]
        public void WikiSearch()
        {
            
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.wikipedia.org/");
            driver.Manage().Window.Maximize();

            List<string> CentralLenguages = new List<string>();
            ReadOnlyCollection<IWebElement> languages = driver.FindElements(By.ClassName("central-featured-lang"));
            foreach (IWebElement language in languages)
            {
                string lang = language.Text;
                lang = lang.Substring(0, lang.LastIndexOf("\r"));
                CentralLenguages.Add(lang);
            }

            string stop = "";

            SelectElement selectLanguage = new SelectElement(driver.FindElement(By.Id("searchLanguage")));
            selectLanguage.SelectByText("Dansk");
            selectLanguage.SelectByValue("be");
            selectLanguage.SelectByIndex(0);
            #region

            //List<String> textofanchor = new List<string>();
            //IReadOnlyCollection<IWebElement> anchorlist = driver.FindElements(By.TagName("a"));
            //foreach (IWebElement anchor in anchorlist)
            //{
            //    if (anchor.Text.Length>0)
            //    {
            //        if (anchor.Text.Contains("English"))
            //        {
            //            textofanchor.Add(anchor.Text);
            //            anchor.Click();
            //        }

            //    }

            //}

            //string stop = "";
            ////driver.FindElement(By.XPath("//input[@id='searchInput']")).SendKeys("Selenium");
            ////driver.FindElement(By.XPath("//button[@class='pure-button pure-button-primary-progressive']")).Click();
            #endregion

            driver.Quit();

        }



        [TestMethod]
        public void ChromeMethod()
        {
            string actualResult;
            string expectedResult = "Bingo";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            actualResult = driver.Title;
            if (actualResult.Contains(expectedResult))
            {
                Console.WriteLine("The Test Case Passed");
                Assert.IsTrue(true, "The Test Case Passed");
            }
            else
            {
                Console.WriteLine("The Test Case Failed");
            }
            driver.Close();
            driver.Quit();

        }

        public void FirefoxMethod()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();

        }
        public void EdgeMethod()
        {
            IWebDriver driver = new EdgeDriver();
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.Manage().Window.Maximize();
            driver.Close();
            driver.Quit();

        }
        
    }
}
