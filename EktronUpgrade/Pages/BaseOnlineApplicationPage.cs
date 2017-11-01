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
     class BaseOnlineApplicationPage : BasePage
    {

        public string applicationName;


        public IWebElement PostCodeTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_PostcodeTextBox_PostcodeFormTextBox", applicationName)));
        }

        public IWebElement CheckBtn()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_CheckButton_CheckFormButton", applicationName)));
        }

        public IWebElement MapFrame()
        {
            return driver.FindElement(By.XPath(string.Format("//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_ctl00_mapDiv']/div/div/div[1]/div[3]/div", applicationName)));
        }

        public IWebElement DrawBoundaryBtn()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_ctl00_DrawSiteBoundary_DrawSiteBoundaryFormButton", applicationName)));
        }

        public IWebElement GeneralDescriptionTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_GeneralRequirements_GeneralRequirementsFormTextBox", applicationName)));
        }

        public IWebElement GridReferenceTxf() 
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_GridReference_GridReferenceFormTextBox", applicationName)));
        }

        public IWebElement UndergroundCablesChb()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_UndergroundCables_UndergroundCablesFormCheckBox", applicationName)));
        }

        public IWebElement TotalNumberOfConnectionsTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_TotalNumberOfConnections_TotalNumberOfConnectionsFormTextBox", applicationName)));
        }

        public IWebElement NumberOfTransfers()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_NumberOfTransfers_NumberOfTransfersFormTextBox", applicationName)));
        }

        public IWebElement NumberOfDisconnections()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_NumberOfDisconnections_NumberOfDisconnectionsFormTextBox", applicationName)));
        }

        public IWebElement JobDescriptionTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_JobDescription_JobDescriptionFormTextBox", applicationName)));
        }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ConfirmButton_ConfirmFormButton_8")]
        public IWebElement ConfirmBtn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ConfirmButton_ConfirmFormButton_9")]
        public IWebElement Confirm9Btn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ConfirmButton_ConfirmFormButton_10")]
        public IWebElement Confirm10Btn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ContinueButton_ContinueFormButton_1")]
        public IWebElement ContinueBtn { get; set; }

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

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_8")]
        public IWebElement Next8Btn { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_9")]
        public IWebElement Next9Btn { get; set; }





        public IWebElement HavePlacedMyPinChb()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_ctl00_ConfirmBoundaryLocation_CheckModifiedSiteBoundaryFormCheckBox", applicationName)));
        }

        public IWebElement PropertyNumberTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_FlatHouseNoTextBox_FlatHouseNoFormTextBox", applicationName)));
        }

        public IWebElement AddressTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_AddressTextBox_AddressFormTextBox", applicationName)));
        }

        public IWebElement PostcodeSearchTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_quickAddressUserControl_PostcodeSearchTextBox_PostcodeSearchFormTextBox", applicationName)));
        }

        public IWebElement FindAddressBtn()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_quickAddressUserControl_QuickAddressSubmitButton_SubmitFormButton", applicationName)));
        }

        public IWebElement AddressFirstOption()
        {
            return driver.FindElement(By.XPath(string.Format("//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_quickAddressUserControl_addressListBox']/option[1]", applicationName)));
        }

        public IWebElement UseMyContactDetailsBtn()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_MyContactDetailsButton_MyContactDetailsFormButton", applicationName)));
        }

        public IWebElement PhoneNumberTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_PhoneNumber_PhoneNumberFormTextBox", applicationName)));
        }

        public IWebElement NameOfSiteContactTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_SiteContactNameTextBox_SiteContactNameFormTextBox", applicationName)));
        }

        public IWebElement PhoneNumberForSiteContactTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_SiteContactTelephoneTextBox_SiteContactTelephoneFormTextBox", applicationName)));
        }

        public IWebElement EmailForSiteContactTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_SiteContactEmailTextBox_SiteContactEmailFormTextBox", applicationName)));
        }

        public IWebElement PleaseDescribeTypeOfWorkTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_Property1_PropertyWorkDescription_PropertyWorkDescriptionFormTextBox", applicationName)));
        }

        public IWebElement PleaseEnterTotalLoadTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_Property1_PropertyKva_PropertyKvaFormTextBox", applicationName)));
        }

        public IWebElement NumberOfBedrooms()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_Property1_PropertyNumberOfBedrooms_PropertyNumberOfBedroomsFormTextBox", applicationName)));
        }

        public IWebElement ElectricBoilerQuantity()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_Property1_ElectricBoilerFormDualTextBox_TextBox1_ElectricHeatingNumberElectricBoilerFormTextBox", applicationName)));
        }

        public IWebElement ElectricBoilerKw()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_Property1_ElectricBoilerFormDualTextBox_TextBox2_ElectricHeatingRatingElectricBoilerFormTextBox", applicationName)));
        }

        public IWebElement MeterSerialNumberTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_MeterSerialNo_MeterSerialNoFormTextBox", applicationName)));
        }




        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_ExistingConnectionOverhead_ExistingConnectionOverheadFormCheckBox")]
        public IWebElement OverheadChb { get; set; }
        //
        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_MeterPositionDistance_MeterPositionDistanceFormTextBox")]
        public IWebElement MeterPositionTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_FinishButton_FinishFormButton")]
        public IWebElement FinishBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//b")]
        public IWebElement ReferenceNumberTx { get; set; }

       




        public void ClickHavePlacedMyPinChb()
        {
            _methods.ClickAt(HavePlacedMyPinChb());
        }

        public void ClickNextBtn()
        {
            _methods.ClickAt(NextBtn);
        }

        public void ClickNext3Btn()
        {
            _methods.ClickAt(Next3Btn);
        }

        public void ClickNext4Btn()
        {
            _methods.ClickAt(Next4Btn);
        }

        public void ClickNext5Btn()
        {
            _methods.ClickAt(Next5Btn);
        }

        public void ClickNext6Btn()
        {
            _methods.ClickAt(Next6Btn);
        }

        public void ClickNext7Btn()
        {
            _methods.ClickAt(Next7Btn);
        }

        public void ClickNext8Btn()
        {
            _methods.ClickAt(Next8Btn);
        }

        public void ClickNext9Btn()
        {
            _methods.ClickAt(Next9Btn);
        }

        public void ClickUseMyContactDetailsBtn()
        {
            _methods.ClickAt(UseMyContactDetailsBtn());
        }

        public void ClickConfirmBtn()
        {
            _methods.ClickAt(ConfirmBtn);
        }

        public void ClickConfirm10Btn()
        {
            _methods.ClickAt(Confirm10Btn);
        }

        public MyProfilePage ClickFinishBtn()
        {
            _methods.ClickAt(FinishBtn);
            return new MyProfilePage(driver);
        }

        public void FillInPostcodeCheckForm(string postcodeToCheck = "PO6 1UJ")
        {
            _methods.TypeInText(PostCodeTxf(), postcodeToCheck);
            _methods.ClickAt(CheckBtn());
            _methods.ClickAt(ContinueBtn);
        }

        public void FillInSiteAddressForm(string propertyNumber = "1", string address = "Walton Park")
        {
            Actions act = new Actions(driver);
            act.DoubleClick(MapFrame()).Perform();
            act.MoveByOffset(15, 15).DoubleClick().Perform();
            act.DoubleClick(MapFrame()).Perform();
            act.DoubleClick(MapFrame()).Perform();

            _methods.ClickAt(DrawBoundaryBtn());
            ClickHavePlacedMyPinChb();
            _methods.TypeInText(PropertyNumberTxf(), propertyNumber);
            _methods.TypeInText(AddressTxf(), address);
            ClickNextBtn();
        }

        public void FillInCorrespondenceAddressForm(string postcode = "LU1 1LN", string phoneNumber = "01473223344")
        {
            _methods.TypeInText(PostcodeSearchTxf(), postcode);
            _methods.ClickAt(FindAddressBtn());
            _methods.ClickAt(AddressFirstOption());
            ClickUseMyContactDetailsBtn();
            if (PhoneNumberTxf().GetAttribute("value").Length < 1)
                _methods.TypeInText(PhoneNumberTxf(), phoneNumber);
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
            _methods.TypeInText(NameOfSiteContactTxf(), nameOfContact);
            _methods.TypeInText(PhoneNumberForSiteContactTxf(), phoneNumber);
            _methods.TypeInText(EmailForSiteContactTxf(), email);
            ClickNext5Btn();
        }

        public void FillInApplicationSetupForm()
        {
            _methods.ClickAt(Next6Btn);
        }

        public void FillInApplicationSetupForm(string number)
        {
            _methods.TypeInText(MeterSerialNumberTxf(), number);
            _methods.ClickAt(Next6Btn);
        }


        public void FillInPropertyDetailsForm(string typeOfWork = "automation test", string totalLoad = "12", string numberOfBedrooms = "2", string electricBoilerQty = "1",
            string electricBoilerKw = "10", string gridReference = "NH1234512345")
        {
            _methods.TypeInText(PleaseDescribeTypeOfWorkTxf(), typeOfWork);
            _methods.TypeInText(PleaseEnterTotalLoadTxf(), totalLoad);
            _methods.TypeInText(NumberOfBedrooms(), numberOfBedrooms);
            _methods.TypeInText(ElectricBoilerQuantity(), electricBoilerQty);
            _methods.TypeInText(ElectricBoilerKw(), electricBoilerKw);
            ClickNext7Btn();
        }

        public void FillInAdditionalLoadForm()
        {
            ClickNext8Btn();
        }

        public void FillInAdditionalDetailsForm()
        {
            ClickNext8Btn();
        }

        public void FillInApplicationDetailsForm(string generalDescription = "automation description", string gridReference = "NH1234512345", string number="2")
        {          
            _methods.TypeInText(GeneralDescriptionTxf(), generalDescription);
            _methods.TypeInText(GridReferenceTxf(), gridReference);
            _methods.TypeInText(TotalNumberOfConnectionsTxf(), number);
            _methods.ClickAt(Next6Btn);
        }

        public void FillInSupportingDocumentsForm()
        {
            ClickNext9Btn();
        }

        public void FillInSummaryForm()
        {
            ClickConfirm10Btn();
        }

        public void FillInPropertyTypesForm()
        {
            ClickNext7Btn();
        }
    }
}
