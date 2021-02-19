using Exercise3_AutomationCSharp.Base;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_AutomationCSharp.POM
{
    class AmazonFrontPage : MyDriver
    {
        #region WebElements
        public IWebElement LoginButton { get; set; }
        #endregion
        public AmazonFrontPage GoToFrontPage() {
            browser.GoToUrl("https://amazon.com.mx");
            return this;
        }
    }
}
