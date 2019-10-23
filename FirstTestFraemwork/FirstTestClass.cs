using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using System.Threading;

namespace FirstTestFraemwork
{
    [TestClass]
    public class FirstTestClass
    {
        [TestMethod]
        public void LoginPage()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                driver.Navigate().GoToUrl("https://qa-portal.tradelize.com/");
                driver.Manage().Window.Maximize();
                Thread.Sleep(10000);
                driver.FindElement(By.XPath("//div[@id='login']//div[1]//input[1]")).SendKeys("tqav3@yopmail.com");
                driver.FindElement(By.XPath("//input[@placeholder='ENTER YOUR PASSWORD HERE']")).SendKeys("12345");
                driver.FindElement(By.ClassName("welcome-btn")).Click();

                IWebElement SideBarContainer = driver.FindElement(By.Id("sidebar"));
                ReadOnlyCollection<IWebElement> SidebarAnchors = SideBarContainer.FindElements(By.TagName("a"));
                foreach (IWebElement sidebarAnchor in SidebarAnchors)
                {
                    string AnchorName = sidebarAnchor.Text;
                    sidebarAnchor.Click();
                    Thread.Sleep(5000);
                }

            }

            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.ToString());
            }

            finally
            {
                driver.Close();
                driver.Quit();
            }
        }


        [TestMethod]
        public void RegistrationPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://qa-portal.tradelize.com/");
            driver.Manage().Window.Maximize();
            driver.FindElement(By.XPath("//a[contains(text(),'OR REGISTER NOW')]")).Click();
            driver.FindElement(By.XPath("//input[@placeholder='LOGIN']")).SendKeys("");  //user login
            driver.FindElement(By.XPath("//input[@placeholder='EMAIL']")).SendKeys(""); //user email
            driver.FindElement(By.XPath("//input[@placeholder='RETYPE EMAIL']")).SendKeys(""); //retype email
            driver.FindElement(By.XPath("//input[@placeholder='PASSWORD']")).SendKeys(""); // password
            driver.FindElement(By.XPath("//input[@placeholder='RETYPE PASSWORD']")).SendKeys(""); // retype password
            driver.FindElement(By.XPath("//input[@placeholder='PRIVATE BETA INVITE CODE']")).SendKeys(""); // invite code
            driver.FindElement(By.TagName("i")).Click();
            driver.FindElement(By.ClassName("btn-welcome"));
        }
        
        
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


        




    }
}
