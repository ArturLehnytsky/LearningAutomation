using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestFraemwork
{
    public class LoginPage
    {
        IWebDriver driver;

        By userLogin = By.XPath("//div[@id='login']//div[1]//input[1]");
        By userPassword = By.XPath("//input[@placeholder='ENTER YOUR PASSWORD HERE']");
        By btnWelcome = By.ClassName("welcome-btn");

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void TypeUsername()
        {
            driver.FindElement(userLogin).SendKeys("tqav3@yopmail.com");

        }

        public void TypePassword()
        {
            driver.FindElement(userPassword).SendKeys("12345");
        }

        public void ClickOnWelcomeBtn()
        {
            driver.FindElement(btnWelcome).Click();
        }
    }
}
