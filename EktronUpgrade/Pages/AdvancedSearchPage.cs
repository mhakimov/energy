using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class AdvancedSearchPage : BasePage
    {

        public AdvancedSearchPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='contentContainer']/section/article[4]/div/h3")]
        public IWebElement SearchResultsTx { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_DateFrom_DateFromFormDatePicker")]
        public IWebElement DateFromTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_DateTo_DateToFormDatePicker")]
        public IWebElement DateToTfx { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[1]/div/div/label")]
        public IWebElement SafetyChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[2]/div/div/label")]
        public IWebElement ConnectionsChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[3]/div/div/label")]
        public IWebElement ReliabilityChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[4]/div/div/label")]
        public IWebElement EnvironmentChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[5]/div/div/label")]
        public IWebElement InnovationChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div/div[2]/div[6]/div/div/label")]
        public IWebElement CustomerServiceChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[3]/div/div[2]/div[1]/div/div/label")]
        public IWebElement EnglandChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[3]/div/div[2]/div[2]/div/div/label")]
        public IWebElement ScotlandChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[3]/div/div[2]/div[3]/div/div/label")]
        public IWebElement WalesChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_SearchClick_SearchFormButton")]
        public IWebElement SearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]/div[1]/div/a/div/div[1]/span")]
        public IWebElement EventNameTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]/div[1]/div/a/div/div[2]/span")]
        public IWebElement EventDateTx { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_SearchResults-stakeholder-basicsearch-intro-0")]
        public IWebElement EventDescriptionTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]/div[2]/div/div[2]/div[1]/div/a")]
        public IWebElement ContactOrganiserBtn { get; set; }


        public void ChooseCategoriesAndRegions(IWebElement[] categories)
        {
            foreach (var category in categories)
            {
                _methods.ClickAt(category);
            }
        }

        public void ClickSearch()
        {
            _methods.ClickAt(SearchBtn);
        }

        public void TypeInDateFrom(string value)
        {
            _methods.TypeInText(DateFromTxf, value);
        }

        public void TypeInDateTo(string value)
        {
            _methods.TypeInText(DateToTfx, value);
        }

    }
}
