using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using OpenQA.Selenium;

namespace TestPractice.Factory
{

    public class ResponsiveLoginPage : ILoginPage
    {
        private readonly IWebDriver _driver;
        public ResponsiveLoginPage(IWebDriver driver) { _driver = driver; }

        public void EnterUsername(string username)
        {
            _driver.FindElement(By.Id("username")).SendKeys(username);
        }

        public void EnterPassword(string password)
        {
            _driver.FindElement(By.Id("password")).SendKeys(password);
        }

        public void ClickLogin()
        {
            _driver.FindElement(By.Id("submit")).Click();
        }
    }
}
