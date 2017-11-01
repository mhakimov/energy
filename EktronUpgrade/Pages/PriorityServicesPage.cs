using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace EktronUpgradeSse.Pages
{
    class PriorityServicesPage
    {
        private IWebDriver driver;
        private Methods _methods;

        public PriorityServicesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        [FindsBy(How = How.XPath, Using = "//div/div/div/ul/li[2]/a")]
        public IWebElement HereBtn { get; set; }

        public void ClickHereBtn()
        {
            _methods.ClickAt(HereBtn);
        }

        public PriorityServicesRegistrationPage NavigateToPriorityServicesRegistrationPage()
        {
       //     _methods.ScrollIntoView(HereBtn);
            ClickHereBtn();
            return new PriorityServicesRegistrationPage(driver);
        }

        
    }
}
