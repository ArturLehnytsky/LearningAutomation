using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;

namespace FirstTestFraemwork
{
    [TestFixture]
    [Parallelizable]
    public class NUnitParallelTest : Base
    {
        [Test]
        public void SearchGoogle()
        {
           
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("C#");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("btnK")).Click();
            System.Threading.Thread.Sleep(5000);
        }

        [Test]
        public void SearchGoogle1A()
        {

            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("Java");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("btnK")).Click();
            System.Threading.Thread.Sleep(5000);
        }
    }

    [TestFixture]
    [Parallelizable]
    public class NUnitParallelTest2 : Base
    {
        [Test]
        public void SearchGoogle2()
        {
            
            driver.Navigate().GoToUrl("https://www.google.com/");
            driver.FindElement(By.Name("q")).SendKeys("C#");
            System.Threading.Thread.Sleep(1000);
            driver.FindElement(By.Name("btnK")).Click();
            System.Threading.Thread.Sleep(10000);
        }
    }
}
