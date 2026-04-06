using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using TextCopy;


namespace SkilReview
{
    public class CopyPaste
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        [SetUp]
        public void Setup()
        {
            var options = new ChromeOptions();
            options.AddArgument("--incognito");
            driver = new ChromeDriver(options);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        [Test]
        public void LoginAndCopyText()
        {
            wait.Until(ExpectedConditions.ElementIsVisible(By.Id("user-name"))).SendKeys("standard_user");
            driver.FindElement(By.Id("password")).SendKeys("secret_sauce");
            driver.FindElement(By.Id("login-button")).Click();
            var firstItem = wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("inventory_item_name")));
            IWebElement element = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[contains(text(),'uncompromising')]")));
            ((IJavaScriptExecutor)driver).ExecuteScript(@"
            var range = document.createRange();
            range.selectNode(arguments[0]);
            window.getSelection().removeAllRanges();
            window.getSelection().addRange(range);
        ",element);

            Actions actions = new Actions(driver);
            actions.MoveToElement(element).DoubleClick().KeyDown(Keys.Shift).SendKeys(Keys.ArrowLeft).SendKeys(Keys.ArrowLeft).SendKeys(Keys.ArrowLeft).KeyUp(Keys.Shift)
            .KeyDown(Keys.Control).SendKeys("c").KeyUp(Keys.Control).Perform();


            string clipboardText = ClipboardService.GetText();
            Console.WriteLine("Clipboard contains: " + clipboardText);

        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                
                driver?.Quit();
            }
            finally
            {
                
                driver?.Dispose();
                driver = null;
            }
        }
    }
}
