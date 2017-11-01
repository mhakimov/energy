using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class EventsPage
    {

         private IWebDriver driver;
        private Methods _methods;

        public EventsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        int eventIndex = 1;

        [FindsBy(How = How.XPath, Using = "//article[4]/div/div/div[1]/div[1]")]
        public IWebElement Calendar { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]/div[1]/div/a/div/div[1]")]
        public IWebElement FirstEventMenu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_ctl00-stakeholder-basicsearch-full-0']/div[1]/div[1]")]
        public IWebElement StartDate { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_AdvancedSearchClick_AdvancedSearchFormButton")]
        public IWebElement AdvancedSearchBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div[2]/div/div[2]/div[1]/div/a")]
        public IWebElement ContactOrganiserBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='contentContainer']/section/article[4]/div/div/div[1]/div[1]/div[1]/div[3]/a/span")]
        public IWebElement CalendarNextPage { get; set; }

        public void ClickFutureEvent()
        {
            _methods.ClickAt(CalendarNextPage);

            IWebElement date = driver.FindElement(By.XPath(string.Format("//*[@id='contentContainer']/section/article[4]/div/div/div[2]/div[{0}]/div[1]/div/a/div/div[2]/span", eventIndex.ToString())));
            while (Convert.ToDateTime(date.Text) < DateTime.Now)
            {
                eventIndex++;
                try
                {
                    date = driver.FindElement(By.XPath(string.Format("//*[@id='contentContainer']/section/article[4]/div/div/div[2]/div[{0}]/div[1]/div/a/div/div[2]/span", eventIndex.ToString())));
                }
                catch (NoSuchElementException)
                {
                    _methods.ClickAt(CalendarNextPage);
                    date = driver.FindElement(By.XPath(string.Format("//*[@id='contentContainer']/section/article[4]/div/div/div[2]/div[1]/div[1]/div/a/div/div[2]/span")));
                }
            }
            _methods.ClickAt(date);
        }

        public IWebElement GetStartDate()
        {
            string path = string.Format("//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_ctl00-stakeholder-basicsearch-full-{0}']/div[1]/div[2]", eventIndex-1);
            return driver.FindElement(By.XPath(path));
        }

        public EventRegisterationPage ClickRegisterNow()
        {  
            _methods.ClickAt(driver.FindElement(By.XPath(string.Format("//div[{0}]/div[2]/div/div[2]/div[2]/div/a", eventIndex))));
            return new EventRegisterationPage(driver);
        }


        public void ClickFirstEventMenu()
        {
            _methods.ClickAt(FirstEventMenu);
        }

        public AdvancedSearchPage ClickAdvancedSearch()
        {
            _methods.ClickAt(AdvancedSearchBtn);
            return new AdvancedSearchPage(driver);
        }

        public AlternativeProviderRegistrationPage NavigateToAlternativeProviderRegistrationPage()
        {
            _methods.ClickAt(Calendar);
            return new AlternativeProviderRegistrationPage(driver);
        }

        public ContactOrganiserPage ClickContactOrganiser()
        {
            _methods.ClickAt(ContactOrganiserBtn);
            return new ContactOrganiserPage(driver);
        }
    }
}
