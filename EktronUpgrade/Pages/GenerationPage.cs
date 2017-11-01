using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages.OnlineApplications
{
    class GenerationPage
    {
           private IWebDriver driver;
        private Methods _methods;

        public GenerationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone2_uxColumnDisplay_ctl00_uxControlColumn_ctl00_uxWidgetHost_uxWidgetHost_widget_applicationStart_applicationStartLinks_ListLinks_listul']/li[2]/div/a/span")]
        public IWebElement StartOnlineApplicationForMicrogeneration { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone2_uxColumnDisplay_ctl00_uxControlColumn_ctl02_uxWidgetHost_uxWidgetHost_widget_applicationStart_applicationStartLinks_ListLinks_listul']/li[2]/div/a/span")]
        public IWebElement StartOnlineApplicationForDistributedGeneration { get; set; }

        public DistributedGenerationPage NavigateToDistributedGenerationPage()
        {
            _methods.ClickAt(StartOnlineApplicationForDistributedGeneration);
            return new DistributedGenerationPage(driver);
        }

        public MicroGenerationPage NavigateToMicroGenerationPage()
        {
            _methods.ClickAt(StartOnlineApplicationForMicrogeneration);
            return new MicroGenerationPage(driver);
        }
    }
}
