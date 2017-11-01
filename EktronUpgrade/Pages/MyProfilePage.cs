using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace EktronUpgradeSse.Pages
{
    class MyProfilePage :BasePage
    {
        //private IWebDriver driver;
        //private Methods _methods;

        public MyProfilePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        [FindsBy(How = How.XPath, Using = "//div[3]/div[1]/section/div/div/div/section/div[2]/div/a")]
        public IWebElement JobTrackingBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/section/div/div/div/section/div[2]/div/a")]
        public IWebElement MakeApplicationBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//section/div[1]/div/div/div/p")]
        public IWebElement UpcomingEventsTx { get; set; }
        ////*[@id="contentContainer"]/section/div[2]/div[1]/div[1]/div[5]/div/section/div/div/div/section/div[2]/div/a
        //[FindsBy(How = How.XPath, Using = "//div[4]/div/section/div/div/div/section/div[2]/div/a")]
        //public IWebElement ViewAllEventsBtn { get; set; }

        [FindsBy(How = How.CssSelector, Using = "a[href='/StakeholderEvent/BasicSearch']")]
        public IWebElement ViewAllEventsBtn { get; set; }

        [FindsBy(How = How.ClassName, Using = "my-profile-heading")]
        public IWebElement EventHeadingTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div[3]/div/a")]
        public IWebElement CancelRegistrationBtn { get; set; }

        public void ClickMakeApplicationBtn()
        {
          //  _methods.ScrollIntoView(MakeApplicationBtn);
            _methods.ClickAt(MakeApplicationBtn);
        }

        public void ClickCancelRegistrationBtn()
        {
            _methods.ClickAt(CancelRegistrationBtn);
        }

        public JobTrackingPage NavigateToJobTrackingPage()
        {
            _methods.ClickAt(JobTrackingBtn);
            return new JobTrackingPage(driver);
        }

        public OnlineApplicationsPage NavigateToOnlineApplicationsPage()
        {
            ClickMakeApplicationBtn();
            return new OnlineApplicationsPage(driver);
        }

        public EventsPage ClickViewAllEventsBtn()
        {
            _methods.ClickAt(ViewAllEventsBtn);
            return new EventsPage(driver);
        }
    }
}
