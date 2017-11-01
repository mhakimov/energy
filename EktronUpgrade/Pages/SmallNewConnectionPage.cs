using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;


namespace EktronUpgradeSse.Pages.OnlineApplications
{
    class SmallNewConnectionPage : BaseOnlineApplicationPage
    {
       

        public SmallNewConnectionPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
          applicationName = "SmallNewConnectionContents";
        }

        
    }
}
