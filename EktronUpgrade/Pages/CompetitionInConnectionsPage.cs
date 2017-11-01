using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class CompetitionInConnectionsPage
    {
         private IWebDriver driver;
        private Methods _methods;

        public CompetitionInConnectionsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }


        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_BodyPlaceHolder_DropZone1_uxColumnDisplay_ctl00_uxControlColumn_ctl03_uxWidgetHost_uxWidgetHost_widget_repeatableFeatureBlock_RepeatableContentContainer_ctrl2_RepeatableContent_UnderContentLinks_ListLinks_listul']/li/div/a/span")]
        public IWebElement RegisterAsAnApBtn { get; set; }

        public AlternativeProviderRegistrationPage NavigateToAlternativeProviderRegistrationPage()
        {
            _methods.ClickAt(RegisterAsAnApBtn);
            return new AlternativeProviderRegistrationPage(driver);
        }
    }
}
