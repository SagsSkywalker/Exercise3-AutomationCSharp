using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_AutomationCSharp.Base
{
    class MyDriver
    {
        protected MyBrowser browser;
        protected IWebDriver driver;
        public MyDriver() {
            browser = new MyBrowser();
            driver = browser.CreateBrowser();
            PageFactory.InitElements(driver, this);
        }
    }
}
