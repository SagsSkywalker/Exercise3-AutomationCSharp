using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_AutomationCSharp.Base
{
    class MyBrowser
    {
        IWebDriver driver;
        public IWebDriver CreateBrowser() {
            driver = new ChromeDriver(@"C:\Webdrivers\");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
            //driver.Navigate().GoToUrl("https://www.unosquare.com");
            return driver;
        }

        public void Click(IWebElement element) {
            element.Click();
        }

        public void WriteInElement(IWebElement element, string value) {
            element.SendKeys(value);
        }

        public void GoToUrl(string url) {
            driver.Navigate().GoToUrl(url);
        }
    }
}
