using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_AutomationCSharp.POM
{
    class AmazonLoginPage
    {
        #region WebElements
        public IWebElement EmailField { get; set; }
        public IWebElement ContinueButton { get; set; }
        public IWebElement LoginButton { get; set; }
        #endregion
    }
}
