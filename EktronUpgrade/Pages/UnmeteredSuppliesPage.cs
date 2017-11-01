using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;


namespace EktronUpgradeSse.Pages.OnlineApplications
{
    class UnmeteredSuppliesPage : BaseOnlineApplicationPage
    {

        public UnmeteredSuppliesPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
         // applicationName = "UnmeteredConnectionContents";
        }

        [FindsBy(How = How.CssSelector, Using = "a[href='/Forms/Unmetered']")]
        public IWebElement OnlineApplicationBtn { get; set; }

        public UnmeteredConnectionPage NavigateToUnmeteredConnectionPage()
        {
            _methods.ClickAt(OnlineApplicationBtn);
            return new UnmeteredConnectionPage(driver);
        }

      
    }
}
