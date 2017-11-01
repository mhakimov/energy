using EktronUpgradeSse.Pages.OnlineApplications;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class OnlineApplicationsPage
    {
        private IWebDriver driver;
        private Methods _methods;

        public OnlineApplicationsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone4_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']//..//a")]
        public IWebElement ServiceAlterationApplyOnlineBtn { get; set; }
                                           
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone2_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']//..//a")]
        public IWebElement SmallNewConnectionApplyOnlineBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone3_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']//..//a")]
        public IWebElement LargeNewConnectionApplyOnlineBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone5_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxUpdatePanel']//../a")]
        public IWebElement DiversionApplyOnlineBtn { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone2_uxColumnDisplay_ctl00_uxControlColumn_ctl01_uxWidgetHost_uxUpdatePanel']//..//a")]
        public IWebElement GenerationApplyOnlineBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone3_uxColumnDisplay_ctl00_uxControlColumn_ctl01_uxWidgetHost_uxUpdatePanel']//..//a")]
        public IWebElement IncreaseElectricalCapacityApplyOnlineBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone4_uxColumnDisplay_ctl00_uxControlColumn_ctl01_uxWidgetHost_uxUpdatePanel']//..//a")]
        public IWebElement UnmeteredConnectionFindOutBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone5_uxColumnDisplay_ctl00_uxControlColumn_ctl01_uxWidgetHost_uxUpdatePanel']//..//a")]
        public IWebElement NonContestableWorksFindOutBtn { get; set; }

        public void ClickServiceAlterationApplyOnlineBtn()
        {
            _methods.ClickAt(ServiceAlterationApplyOnlineBtn);
        }

        public void ClickLargeNewConnectionApplyOnlineBtn()
        {
            _methods.ClickAt(LargeNewConnectionApplyOnlineBtn);
        }

        public ServiceAlterationPage NavigateToServiceAlterationPage()
        {
            ClickServiceAlterationApplyOnlineBtn();
            return new ServiceAlterationPage(driver);
        }

        public LargeNewConnectionPage NavigateToLargeNewConnectionPage()
        {
            ClickLargeNewConnectionApplyOnlineBtn();
            return new LargeNewConnectionPage(driver);
        }

        public SmallNewConnectionPage NavigateToSmallNewConnectionPage()
        {
            _methods.ClickAt(SmallNewConnectionApplyOnlineBtn);
            return new SmallNewConnectionPage(driver);
        }

        public DiversionPage NavigateToDiversionPage()
        {
            _methods.ClickAt(DiversionApplyOnlineBtn);
            return new DiversionPage(driver);
        }

        public GenerationPage NavigateToGenerationPage()
        {
            _methods.ClickAt(GenerationApplyOnlineBtn);
            return new GenerationPage(driver);
        }

        public IncreaseCapacityPage NavigateToIncreaseCapacityPage()
        {
            _methods.ClickAt(IncreaseElectricalCapacityApplyOnlineBtn);
            return new IncreaseCapacityPage(driver);
        }

        public UnmeteredSuppliesPage NavigateToUnmeteredSuppliesPage()
        {
            _methods.ClickAt(UnmeteredConnectionFindOutBtn);
            return new UnmeteredSuppliesPage(driver);
        }

    }
}
