using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class BasePage
    {
        public IWebDriver driver;
        public Methods _methods;

        [FindsBy(How = How.XPath, Using = "//div[3]/div/div/div/div[2]/div/div[1]")]
        public IWebElement AccountBtn { get; set; }
        //
        [FindsBy(How = How.Id, Using = "ctl00_Header_ctl01_signInButton")]
        public IWebElement SignInBtn { get; set; }

      

        [FindsBy(How = How.XPath, Using = "//div[3]/div/div/div/div[2]/div/div[2]")]
        public IWebElement MenuBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='navbar-collapse-grid']/ul/li[1]/a")]
        public IWebElement PowerCutsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='navbar-collapse-grid']/ul/li[2]/a")]
        public IWebElement ConnectionsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[1]/ul/li/div/div[2]/ul/li[2]/a/span[1]")]
        public IWebElement PriorityServicesBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//li[2]/ul/li/div/div[1]/ul/li[7]/a/span[1]")]
        public IWebElement CompetitionInConnectionsBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/ul/li[9]/a/span[1]")]
        public IWebElement EventsBtn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_Header_ctl01_myaccountButton")]
        public IWebElement MyProfileBtn { get; set; }


        public void MakeMenuAppear()
        {
            if (!PowerCutsBtn.Displayed)
                _methods.ClickAt(MenuBtn);
        }

        public CompetitionInConnectionsPage NavigateToCompetitionInConnectionsPage()
        {
            MakeMenuAppear();
            _methods.ClickAt(ConnectionsBtn);
            _methods.ClickAt(CompetitionInConnectionsBtn);
            return new CompetitionInConnectionsPage(driver);
        }

        public EventsPage NavigateToEventsPage()
        {
            MakeMenuAppear();
            _methods.ClickAt(ConnectionsBtn);
            _methods.ClickAt(EventsBtn);
            return new EventsPage(driver);
        }

        public SignInPage NavigateToSignInPage()
        {
            _methods.ClickAt(AccountBtn);
            _methods.ClickAt(SignInBtn);
            return new SignInPage(driver);
        }

        public MyProfilePage NavigateToMyProfilePage()
        {
            _methods.ClickAt(SignInBtn);
            return new MyProfilePage(driver);
        }

        public MyProfilePage NavigateToMyProfilePageWhenSignedIn()
        {
            _methods.ClickAt(AccountBtn);
            _methods.ClickAt(MyProfileBtn); 
            return new MyProfilePage(driver);
        }
    }
}
