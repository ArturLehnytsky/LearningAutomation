using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTestFraemwork
{
    public class LoginPagePF
    {
        //PageFactory -> Tradelize login method
        //Finds @FindBy
        //CacheLookup @CacheLookup
        //How

        [FindsBy(How=How.XPath,Using = "//div[@id='login']//div[1]//input[1]")]
        public IWebElement userlogin { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='ENTER YOUR PASSWORD HERE']")]
        public IWebElement userPassword { get; set; }

        [FindsBy(How = How.ClassName, Using = "welcome-btn")]
        public IWebElement btnWelcome { get; set; }

        public void ClickOnLoginButton()
        {
            btnWelcome.Click();
        }
    }
}
