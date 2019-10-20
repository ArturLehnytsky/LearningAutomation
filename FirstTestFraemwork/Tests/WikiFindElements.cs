using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace FirstTestFraemwork.Tests
{
    [TestClass]
    public class WikiFindElements
    {
        [TestMethod]
        public void FindAndWrite()
        {
            string Expected = "Selenium";
            string Actual;

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
            selectLanguage.SelectByText("Deutsch");
            selectLanguage.SelectByValue("be");
            selectLanguage.SelectByIndex(0);
            #region
            //List<String> textofanchors = new List<string>();
            //ReadOnlyCollection<IWebElement> anchorLists = driver.FindElements(By.TagName("a"));

            //foreach (IWebElement anchor in anchorLists)
            //{
            //    if (anchor.Text.Length>0)
            //    {
            //        if (anchor.Text.Contains("English"))
            //        {
            //            textofanchors.Add(anchor.Text);
                        
            //        }
                    
            //    }
                
            //}

            //string stop = "";
            ////driver.FindElement(By.XPath("//input[@id='searchInput']")).SendKeys("Selenium");
            ////driver.FindElement(By.XPath("//button[@class='pure-button pure-button-primary-progressive']")).Click();
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            //Actual = driver.FindElement(By.Id("firstHeading")).Text;
            //if (Actual.Contains(Expected))
            //{
            //    Console.WriteLine("Test case Passed");
            //    Assert.IsTrue(true, "Test case Passed");
            //}
            //else
            //{
            //    Console.WriteLine( "Test case Failed" );
            //}

            #endregion
            driver.Close();
            driver.Quit();
        }

        
    }
}
