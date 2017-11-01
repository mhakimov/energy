using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;


namespace EktronUpgradeSse.Pages
{
    class ContactOrganiserPage : BasePage
    {

        public ContactOrganiserPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        int eventIndex = 1;


        [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div[2]/div[2]")]
        public IWebElement StartDateTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div[3]/div[2]")]
        public IWebElement EndDateTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//div/div/div[1]/div[8]/div[2]")]
        public IWebElement OrganiserNameTx { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_YourName_YourNameFormTextBox")]
        public IWebElement NameTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_ContactNumber_ContactNumberFormTextBox")]
        public IWebElement ContactNumberTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_EmailAddress_EmailAddressFormTextBox")]
        public IWebElement EmailAddressTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_Message_MessageFormTextBox")]
        public IWebElement MessageTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ctl00_SendMessageButton_SendMessageFormButton")]
        public IWebElement SendMessageBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div[2]/div")]
        public IWebElement EmailSentTx { get; set; }

        public IList<IWebElement> GetList()
        {
            return driver.FindElements(By.CssSelector(".col-xs-12.col-sm-12.col-md-9"));
        }

        public void CheckThatAllDetailsAreEnabled()
        {
            foreach (IWebElement item in GetList())
            {
                Assert.That(item.Displayed);
                Assert.That(item, Is.Not.Null);
            }
        }


        public void FillInTheFormAndSendMessage(string name = "Mike", string number = "01234555666", string email = "a@b.com", string message= "Hello Organiser!")
        {
            _methods.TypeInText(NameTxf, name);
            _methods.TypeInText(ContactNumberTxf, number);
            _methods.TypeInText(EmailAddressTxf, email);
            _methods.TypeInText(MessageTxf, message);
            _methods.ClickAt(SendMessageBtn);
        }

        //public void test() { 
        //    var k =  x.FindElements(By.ClassName("col-md-9")).First(p => p.Text == "start date:"); 
        //    foreach(var x in ListOfDetails)
        //    {
        //        String str = x.FindElement(By.ClassName("col-md-3")).Text;

        //        if(str.ToLower().Equals("start date:")){
                    
        //        }

        //    }
        
        //}
    }
}
