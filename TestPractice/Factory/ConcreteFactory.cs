using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TestPractice.Factory
{

    public class WebLoginPageFactory : LoginPageFactory
    {
        public WebLoginPageFactory(IWebDriver driver) : base(driver) { }
        public override ILoginPage CreateLoginPage()
        {
            return new WebLoginPage(_driver);
        }
    }
  

public class ResponsiveLoginPageFactory : LoginPageFactory
    {
        public ResponsiveLoginPageFactory(IWebDriver driver) : base(driver) { }
        public override ILoginPage CreateLoginPage()
        {
           _driver.Manage().Window.Size = new System.Drawing.Size(375, 812);
            return new ResponsiveLoginPage(_driver);
        }
    }
}
