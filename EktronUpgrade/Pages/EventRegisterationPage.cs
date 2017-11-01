using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class EventRegisterationPage : BasePage
    {


        public EventRegisterationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        [FindsBy(How = How.XPath, Using = "//article[4]/div/div/div[2]/div[1]/div/span")]
        public IWebElement RegisterYourDetailsTx { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_ContactFirstName_ContactFirstNameFormTextBox")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_ContactLastName_ContactLastNameFormTextBox")]
        public IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_ContactNumber_ContactNumberFormTextBox")]
        public IWebElement ContactNumber { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_ContactEmail_ContactEmailFormTextBox")]
        public IWebElement ContactEmail { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_RegisterForEventClick_RegisterForEventFormButton")]
        public IWebElement RegisterForEventBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/p")]
        public IWebElement ThankYouForRegisteringTx { get; set; }

        [FindsBy(How = How.ClassName, Using = "stakeholder-heading")]
        public IWebElement EventNameTx { get; set; }

        public void FillInRegistrationForm(string firstName = "", string lastName = "", string contactNumber = "01234555444", string email = "")
        {
            _methods.TypeInText(FirstName, firstName);
            _methods.TypeInText(LastName, lastName);
            _methods.TypeInText(ContactNumber, contactNumber);
            _methods.TypeInText(ContactEmail, email);
            _methods.ClickAt(RegisterForEventBtn);
        }


    }
}
