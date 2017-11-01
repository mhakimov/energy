using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class JobTrackingPage
    {
        private IWebDriver driver;
        private Methods _methods;

        public JobTrackingPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        [FindsBy(How = How.XPath, Using = "//div[3]/div/div/div/div[2]/div/div[1]")]
        public IWebElement AccountBtn { get; set; }
    }
}
