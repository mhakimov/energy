using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class AlternativeProviderRegistrationPage
    {
         private IWebDriver driver;
        private Methods _methods;

        public AlternativeProviderRegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_DropZone1_uxColumnDisplay_ctl00_uxControlColumn_ctl03_uxWidgetHost_uxWidgetHost_widget_repeatableFeatureBlock_RepeatableContentContainer_ctrl2_RepeatableContent_UnderContentLinks_ListLinks_listul")]
        public IWebElement RegisterAsAnApBtn { get; set; }
        //
        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_AlternativeProviderRegistrationContents_AlternativeProviderRegistrationRegister_CompanyType_CompanyTypeFormDropDownList")]
        public IWebElement CompanyTypeDdm { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_AlternativeProviderRegistrationContents_AlternativeProviderRegistrationRegister_CompanyName_CompanyNameFormTextBox")]
        public IWebElement CompanyNameTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_AlternativeProviderRegistrationContents_AlternativeProviderRegistrationRegister_AddressLine1_AddressLine1FormTextBox")]
        public IWebElement AddressLineTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_AlternativeProviderRegistrationContents_AlternativeProviderRegistrationRegister_ContactTelNo_ContactTelNoFormTextBox")]
        public IWebElement PhoneNumberTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_AlternativeProviderRegistrationContents_AlternativeProviderRegistrationRegister_ContactEmail_ContactEmailFormTextBox")]
        public IWebElement EmailAddressTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_AlternativeProviderRegistrationContents_AlternativeProviderRegistrationRegister_AlternativeProviderLocation_LocationsScotland_LocationsScotlandMultiOptionCheckBoxList_ctrl1_ctl00_LocationsScotlandMultiOptionCheckBoxList_10FormCheckBox")]
        public IWebElement HighlandsChb2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div/div[2]/div/div/label")]
        public IWebElement HighlandsChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div/div[4]/div/div/label")]
        public IWebElement OrkneyChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div/div[7]/div/div/label")]
        public IWebElement WesternIslesChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[4]/div[1]/div/div[3]/div/div/label")]
        public IWebElement OxfordChb { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[1]/div/div/div[2]/div/div/label")]
        public IWebElement ExtraHighVoltageOverheadChb { get; set; }
        //*[@id="contentContainer"]/section/div[2]/div[1]/fieldset[2]/div[1]/div/div/div[6]/div/div/label
        [FindsBy(How = How.XPath, Using = "//div[1]/div/div/div[6]/div/div/label")]
        public IWebElement UnmeteredChb { get; set; }
        //
        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_AlternativeProviderRegistrationContents_AlternativeProviderRegistrationRegister_RegisterButton_RegisterFormButton")]
        public IWebElement RegisterBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//dd[1]")]
        public IWebElement CompanyTypeValueTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//dd[2]")]
        public IWebElement CompanyNameValueTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//dd[4]")]
        public IWebElement AddressValueTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//dd[5]")]
        public IWebElement PhoneNumberValueTx { get; set; }

        [FindsBy(How = How.XPath, Using = "//dd[6]")]
        public IWebElement EmailAddressValueTx { get; set; }
  
        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div/div[2]/div[1]")]
        public IWebElement ScotlandRegionsTx { get; set; }
        // 
        //[FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div/div[2]/div[2]")]
        //public IWebElement EnglandRegionsTx2 { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div/div[2]/div[2]")]
        public IWebElement EnglandRegionsTx { get; set; }
        ////div[2]/div[1]/div/div[3]/div
        [FindsBy(How = How.XPath, Using = "//div[2]/div[1]/div/div[3]/div")]
        public IWebElement TheActivitiesYouWishToEngageInTx { get; set; }


        public void FillInYourCompanyDetails(string typeText = "Independent Distribution Network Operator", string name = "Evil Corporation Plc", string address = "99 Manahattan",
            string number = "01234555666", string email = "bill.gates@microsoft.com")
        {
            SelectCompanyType(typeText);
            _methods.TypeInText(CompanyNameTxf, name);
            _methods.TypeInText(AddressLineTxf, address);
            _methods.TypeInText(PhoneNumberTxf, number);
            _methods.TypeInText(EmailAddressTxf, email);
        }


        public void TickTheAreasAndActivities(IWebElement[] areas = null)
        {
            foreach (var area in areas)
            {
                _methods.ClickAt(area);
            }
        }


        public void ClickRegisterBtn()
        {
            _methods.ClickAt(RegisterBtn);
        }

        public void SelectCompanyType(string option)
        {
            new SelectElement(CompanyTypeDdm).SelectByText(option);
        }
    }
}
