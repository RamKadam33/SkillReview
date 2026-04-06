using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPractice.Factory
{
    public class TestFactory
    {
        [Test]
        public void testFactory()
        {
            IWebDriver driver = new ChromeDriver(); // Properly initialize the driver

           //oginPageFactory factory = new WebLoginPageFactory(driver);
             LoginPageFactory factory = new ResponsiveLoginPageFactory(driver);

            driver.Navigate().GoToUrl("https://practicetestautomation.com/practice-test-login/");
            driver.Manage().Window.Maximize();
            ILoginPage loginPage = factory.CreateLoginPage();
            Thread.Sleep(1000);
            loginPage.EnterUsername("student");
            loginPage.EnterPassword("Password123");
            Thread.Sleep(500);
            loginPage.ClickLogin();
            Thread.Sleep(500);
           Assert.IsTrue( driver.FindElement(By.XPath("//a[text()='Log out']")).Displayed);

            driver.Quit();
        }
    }
}
