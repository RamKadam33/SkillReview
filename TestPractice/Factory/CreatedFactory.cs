using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    using OpenQA.Selenium;

namespace TestPractice.Factory
{

    public abstract class LoginPageFactory
    {
        protected IWebDriver _driver;
        public LoginPageFactory(IWebDriver driver) { _driver = driver; }        
        public abstract ILoginPage CreateLoginPage();
    }
}
