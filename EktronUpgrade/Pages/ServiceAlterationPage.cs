using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages.OnlineApplications
{
    class ServiceAlterationPage
    {
        private IWebDriver driver;
        private Methods _methods;

        public ServiceAlterationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

   

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_CheckButton_CheckFormButton")]
        public IWebElement CheckBtn { get; set; }
        //
        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ConfirmButton_ConfirmFormButton_8")]
        public IWebElement ConfirmBtn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ContinueButton_ContinueFormButton_1")]
        public IWebElement ContinueBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[4]/div[3]/div/img")]
        public IWebElement PinImg { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_PostcodeTextBox_PostcodeFormTextBox")]
        public IWebElement PostcodeTxf { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_ctl00_mapDiv']/div/div/div[1]/div[3]/div")]
        public IWebElement MapFrame { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_ctl00_ConfirmPinLocation_CheckModifiedLatLongFormCheckBox")]
        public IWebElement HavePlacedMyPinChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_AddressTextBox_AddressFormTextBox")]
        public IWebElement AddressTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_2")]
        public IWebElement NextBtn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_3")]
        public IWebElement Next3Btn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_4")]
        public IWebElement Next4Btn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_5")]
        public IWebElement Next5Btn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_6")]
        public IWebElement Next6Btn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_7")]
        public IWebElement Next7Btn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_FlatHouseNoTextBox_FlatHouseNoFormTextBox")]
        public IWebElement PropertyNumberTxf { get; set; }
        //
        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_quickAddressUserControl_PostcodeSearchTextBox_PostcodeSearchFormTextBox")]
        public IWebElement PostcodeSearchTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_quickAddressUserControl_QuickAddressSubmitButton_SubmitFormButton")]
        public IWebElement FindAddressBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_quickAddressUserControl_addressListBox']/option[1]")]
        public IWebElement AddressFirstOption { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_quickAddressUserControl_HouseNameNoTextBox_HouseNameNoFormTextBox")]
        public IWebElement PropertyNameOrNumberTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_MyContactDetailsButton_MyContactDetailsFormButton")]
        public IWebElement UseMyContactDetailsBtn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_MyContactDetailsButton_MyContactDetailsFormButton")]
        //public IWebElement UseMyContactDetailsBtn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_PhoneNumber_PhoneNumberFormTextBox")]
        public IWebElement PhoneNumberTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_SiteContactNameTextBox_SiteContactNameFormTextBox")]
        public IWebElement NameOfSiteContactTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_SiteContactTelephoneTextBox_SiteContactTelephoneFormTextBox")]
        public IWebElement PhoneNumberForSiteContactTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_SiteContactEmailTextBox_SiteContactEmailFormTextBox")]
        public IWebElement EmailForSiteContactTxf { get; set; }
        //
        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_GeneralRequirements_GeneralRequirementsFormTextBox")]
        public IWebElement PleaseDescribeTypeOfWorkTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_MeterSerialNo_MeterSerialNoFormTextBox")]
        public IWebElement MeterSerialNumberTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_ExistingConnectionOverhead_ExistingConnectionOverheadFormCheckBox")]
        public IWebElement OverheadChb { get; set; }
        //
        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_MeterPositionDistance_MeterPositionDistanceFormTextBox")]
        public IWebElement MeterPositionTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_FinishButton_FinishFormButton")]
        public IWebElement FinishBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//b")]
        public IWebElement ReferenceNumberTx { get; set; }


        public void TypeTextInPostcodeTxf(string value)
        {
            _methods.TypeInText(PostcodeTxf, value);
        }

        public void TypeTextInPropertyNumberTxf(string value)
        {
            _methods.TypeInText(PropertyNumberTxf, value);
        }

        public void TypeTextInAddressTxf(string value)
        {
            _methods.TypeInText(AddressTxf, value);
        }

        public void TypeTextInPostcodeSearchTxf(string value)
        {
            _methods.TypeInText(AddressTxf, value);
        }

        public void TypeTextInPhoneNumberTxf(string value)
        {
            _methods.TypeInText(PhoneNumberTxf, value);
        }

        public void ClickCheckBtn()
        {
            _methods.ClickAt(CheckBtn);
        }

        public void ClickConfirmBtn()
        {
        //    _methods.ScrollIntoView(ConfirmBtn);
            _methods.ClickAt(ConfirmBtn);
        }

        public void ClickContinueBtn()
        {
            _methods.ClickAt(ContinueBtn);
        }

        public void ClickPinImg()
        {
        //    _methods.ScrollIntoView(PinImg);
            _methods.ClickAt(PinImg);
        }

        public void ClickHavePlacedMyPinChb()
        {
       //     _methods.ScrollIntoView(HavePlacedMyPinChb);
            _methods.ClickAt(HavePlacedMyPinChb);
        }

        public void ClickNextBtn()
        {
       //     _methods.ScrollIntoView(NextBtn);
            _methods.ClickAt(NextBtn);
        }

        public void ClickNext3Btn()
        {
       //     _methods.ScrollIntoView(Next3Btn);
            _methods.ClickAt(Next3Btn);
        }

        public void ClickNext4Btn()
        {
        //    _methods.ScrollIntoView(Next4Btn);
            _methods.ClickAt(Next4Btn);
        }

        public void ClickNext5Btn()
        {
        //    _methods.ScrollIntoView(Next5Btn);
            _methods.ClickAt(Next5Btn);
        }

        public void ClickNext6Btn()
        {
      //      _methods.ScrollIntoView(Next6Btn);
            _methods.ClickAt(Next6Btn);
        }

        public void ClickNext7Btn()
        {
        //    _methods.ScrollIntoView(Next7Btn);
            _methods.ClickAt(Next7Btn);
        }

        public void ClickUseMyContactDetailsBtn()
        {
       //     _methods.ScrollIntoView(UseMyContactDetailsBtn);
            _methods.ClickAt(UseMyContactDetailsBtn);
        }

        public void ClickFinishBtn()
        {
            _methods.ClickAt(FinishBtn);
        }

        public void FillInPostcodeCheckForm(string postcodeToCheck = "PO6 1UJ")
        {
            _methods.TypeInText(PostcodeTxf, postcodeToCheck);
            _methods.ClickAt(CheckBtn);
            _methods.ClickAt(ContinueBtn);
        }


        public void FillInSiteAddressForm(string propertyNumber = "1", string address = "Walton Park")
        {
            ClickPinImg();
            Actions act = new Actions(driver);
            act.DragAndDrop(PinImg, MapFrame).Build().Perform();
            ClickHavePlacedMyPinChb();
            _methods.TypeInText(PropertyNumberTxf, propertyNumber);
            _methods.TypeInText(AddressTxf, address);
            ClickNextBtn();
        }

        public void FillInCorrespondenceAddressForm(string postcode = "LU1 1LN", string phoneNumber = "01473223344")
        {
            _methods.TypeInText(PostcodeSearchTxf, postcode);
            _methods.ClickAt(FindAddressBtn);
            _methods.ClickAt(AddressFirstOption);
            ClickUseMyContactDetailsBtn();
            if (PhoneNumberTxf.GetAttribute("value").Length < 1)
                _methods.TypeInText(PhoneNumberTxf, phoneNumber);
          //  _methods.TypeInText(PhoneNumberTxf, phoneNumber);
            ClickNext3Btn();
        }

        public void FillInCustomerDetailsForm()
        {
            ClickUseMyContactDetailsBtn();
            ClickNext4Btn();         
        }

        public void FillInSiteContactDetailsForm(string nameOfContact = "Aynur Galimzyanov", string phoneNumber = "01582123456",
            string email = "abc@abc.com")
        {
            _methods.TypeInText(NameOfSiteContactTxf, nameOfContact);
            _methods.TypeInText(PhoneNumberForSiteContactTxf, phoneNumber);
            _methods.TypeInText(EmailForSiteContactTxf, email);
            ClickNext5Btn();
        }

        public void FillInGeneralRequirementsForm(string typeOfWork = "don't care", string meterSerialNumber = "123456789",
           string distanceInMeters = "12")
        {
            _methods.TypeInText(PleaseDescribeTypeOfWorkTxf, typeOfWork);
            _methods.TypeInText(MeterSerialNumberTxf, meterSerialNumber);
        //    _methods.ScrollIntoView(OverheadChb);
            _methods.ClickAt(OverheadChb);
            _methods.TypeInText(MeterPositionTxf, distanceInMeters);
            ClickNext6Btn();
        }

        public void FillInSupportingDocumentsForm()
        {        
            ClickNext7Btn();
        }

        public void FillInSummaryForm()
        {
            ClickConfirmBtn();
        }
    }
}
