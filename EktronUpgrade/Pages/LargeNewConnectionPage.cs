using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;


namespace EktronUpgradeSse.Pages.OnlineApplications
{
    class LargeNewConnectionPage : BaseOnlineApplicationPage
    {
      

        public LargeNewConnectionPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
           applicationName = "LargeNewConnectionContents";
        }

        

        //public IWebElement PostCodeTxf()
        //{
        //    return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_PostcodeTextBox_PostcodeFormTextBox", applicationName)));
        //}

        //public IWebElement CheckBtn()
        //{
        //    return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_CheckButton_CheckFormButton", applicationName)));
        //}

   
        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ConfirmButton_ConfirmFormButton_8")]
        //public IWebElement ConfirmBtn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ConfirmButton_ConfirmFormButton_10")]
        //public IWebElement Confirm10Btn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_ContinueButton_ContinueFormButton_1")]
        //public IWebElement ContinueBtn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_ctl00_DrawSiteBoundary_DrawSiteBoundaryFormButton")]
        //public IWebElement DrawBoundary { get; set; }
     

        //[FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_ctl00_mapDiv']/div/div/div[1]/div[3]/div")]
        //public IWebElement MapFrame { get; set; }
        //////*[@id="ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_ctl00_mapDiv"]/div/div/div[1]/div[3]/div
        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_ctl00_ConfirmBoundaryLocation_CheckModifiedSiteBoundaryFormCheckBox")]
        //public IWebElement HavePlacedMyPinChb { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_AddressTextBox_AddressFormTextBox")]
        //public IWebElement AddressTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_2")]
        //public IWebElement NextBtn { get; set; }
        ////ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_3
        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_3")]
        //public IWebElement Next3Btn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_4")]
        //public IWebElement Next4Btn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_5")]
        //public IWebElement Next5Btn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_6")]
        //public IWebElement Next6Btn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_7")]
        //public IWebElement Next7Btn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_8")]
        //public IWebElement Next8Btn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_NextButton_NextFormButton_9")]
        //public IWebElement Next9Btn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_FlatHouseNoTextBox_FlatHouseNoFormTextBox")]
        //public IWebElement PropertyNumberTxf { get; set; }
        ////
        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_quickAddressUserControl_PostcodeSearchTextBox_PostcodeSearchFormTextBox")]
        //public IWebElement PostcodeSearchTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_quickAddressUserControl_QuickAddressSubmitButton_SubmitFormButton")]
        //public IWebElement FindAddressBtn { get; set; }

        //[FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_quickAddressUserControl_addressListBox']/option[1]")]
        //public IWebElement AddressFirstOption { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_quickAddressUserControl_HouseNameNoTextBox_HouseNameNoFormTextBox")]
        //public IWebElement PropertyNameOrNumberTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_MyContactDetailsButton_MyContactDetailsFormButton")]
        //public IWebElement UseMyContactDetailsBtn { get; set; }

        ////[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_MyContactDetailsButton_MyContactDetailsFormButton")]
        ////public IWebElement UseMyContactDetailsBtn { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_PhoneNumber_PhoneNumberFormTextBox")]
        //public IWebElement PhoneNumberTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_SiteContactNameTextBox_SiteContactNameFormTextBox")]
        //public IWebElement NameOfSiteContactTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_SiteContactTelephoneTextBox_SiteContactTelephoneFormTextBox")]
        //public IWebElement PhoneNumberForSiteContactTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_SiteContactEmailTextBox_SiteContactEmailFormTextBox")]
        //public IWebElement EmailForSiteContactTxf { get; set; }
        ////
        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_GeneralRequirements_GeneralRequirementsFormTextBox")]
        public IWebElement PleaseDescribeTypeOfWorkTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_MeterSerialNo_MeterSerialNoFormTextBox")]
        //public IWebElement MeterSerialNumberTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_ExistingConnectionOverhead_ExistingConnectionOverheadFormCheckBox")]
        //public IWebElement OverheadChb { get; set; }
        ////
        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_MeterPositionDistance_MeterPositionDistanceFormTextBox")]
        //public IWebElement MeterPositionTxf { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_Navigation_FinishButton_FinishFormButton")]
        //public IWebElement FinishBtn { get; set; }

        //[FindsBy(How = How.XPath, Using = "//b")]
        //public IWebElement ReferenceNumberTx { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_TotalNumberOfConnections_TotalNumberOfConnectionsFormTextBox")]
        //public IWebElement TotalNumberOfConnections { get; set; }

        //[FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_LargeNewConnectionContents_ctl00_GridReference_GridReferenceFormTextBox")]
        //public IWebElement GridReferenceTxf { get; set; }


        //public void ClickHavePlacedMyPinChb()
        //{
        //   // _methods.ScrollIntoView(HavePlacedMyPinChb);
        //    _methods.ClickAt(HavePlacedMyPinChb);
        //}

        //public void ClickNextBtn()
        //{
        //  //  _methods.ScrollIntoView(NextBtn);
        //    _methods.ClickAt(NextBtn);
        //}

        //public void ClickNext3Btn()
        //{
        // //   _methods.ScrollIntoView(Next3Btn);
        //    _methods.ClickAt(Next3Btn);
        //}

        //public void ClickNext4Btn()
        //{
        //  //  _methods.ScrollIntoView(Next4Btn);
        //    _methods.ClickAt(Next4Btn);
        //}

        //public void ClickNext5Btn()
        //{
        //  //  _methods.ScrollIntoView(Next5Btn);
        //    _methods.ClickAt(Next5Btn);
        //}

        //public void ClickNext6Btn()
        //{
        //  //  _methods.ScrollIntoView(Next6Btn);
        //    _methods.ClickAt(Next6Btn);
        //}

        //public void ClickNext7Btn()
        //{
        // //   _methods.ScrollIntoView(Next7Btn);
        //    _methods.ClickAt(Next7Btn);
        //}

        //public void ClickNext8Btn()
        //{
        ////    _methods.ScrollIntoView(Next8Btn);
        //    _methods.ClickAt(Next8Btn);
        //}

        //public void ClickNext9Btn()
        //{
        ////    _methods.ScrollIntoView(Next8Btn);
        //    _methods.ClickAt(Next9Btn);
        //}

        //public void ClickUseMyContactDetailsBtn()
        //{
        ////    _methods.ScrollIntoView(UseMyContactDetailsBtn);
        //    _methods.ClickAt(UseMyContactDetailsBtn);
        //}

        //public void ClickConfirmBtn()
        //{
        ////    _methods.ScrollIntoView(ConfirmBtn);
        //    _methods.ClickAt(ConfirmBtn);
        //}

        //public void ClickConfirm10Btn()
        //{
        //    //    _methods.ScrollIntoView(ConfirmBtn);
        //    _methods.ClickAt(Confirm10Btn);
        //}

        //public void ClickFinishBtn()
        //{
        //    _methods.ClickAt(FinishBtn);
        //}

        //public void FillInPostcodeCheckForm(string postcodeToCheck = "PO6 1UJ")
        //{         
        //    _methods.TypeInText(PostCodeTxf(), postcodeToCheck);
        //    _methods.ClickAt(CheckBtn());
        //    _methods.ClickAt(ContinueBtn);
        //}

        //public void FillInSiteAddressForm(string propertyNumber = "1", string address = "Walton Park")
        //{
        ////    _methods.ScrollIntoView(MapFrame);
        //    Actions act = new Actions(driver);
        //    act.DoubleClick(MapFrame).Perform();
        //    act.MoveByOffset(15, 15).DoubleClick().Perform();
        //    //act.DoubleClick(PropertyNumberTxf).Perform();
        //    act.DoubleClick(MapFrame).Perform();
        //    act.DoubleClick(MapFrame).Perform();


        //    _methods.ClickAt(DrawBoundary);
        //    ClickHavePlacedMyPinChb();
        //    _methods.TypeInText(PropertyNumberTxf, propertyNumber);
        //    _methods.TypeInText(AddressTxf, address);
        //    ClickNextBtn();
        //}

        //public void FillInCorrespondenceAddressForm(string postcode = "LU1 1LN", string phoneNumber = "01473223344")
        //{
        //    _methods.TypeInText(PostcodeSearchTxf, postcode);
        //    _methods.ClickAt(FindAddressBtn);
        //    _methods.ClickAt(AddressFirstOption);
        //    ClickUseMyContactDetailsBtn();
        //    if(PhoneNumberTxf.Text.Length < 1)
        //    _methods.TypeInText(PhoneNumberTxf, phoneNumber);
        //    ClickNext3Btn();
        //}

        //public void FillInCustomerDetailsForm()
        //{
        //    ClickUseMyContactDetailsBtn();
        //    ClickNext4Btn();
        //}

        //public void FillInSiteContactDetailsForm(string nameOfContact = "Aynur Galimzyanov", string phoneNumber = "01582123456",
        //    string email = "abc@abc.com")
        //{
        //    _methods.TypeInText(NameOfSiteContactTxf, nameOfContact);
        //    _methods.TypeInText(PhoneNumberForSiteContactTxf, phoneNumber);
        //    _methods.TypeInText(EmailForSiteContactTxf, email);
        //    ClickNext5Btn();
        //}

        public void FillInGeneralRequirementsForm(string totalNumber = "3", string typeOfWork = "don't care", string gridReference = "NH1234512345")
        {
            _methods.TypeInText(TotalNumberOfConnectionsTxf(), totalNumber);
            _methods.TypeInText(PleaseDescribeTypeOfWorkTxf, typeOfWork);
            _methods.TypeInText(GridReferenceTxf(), gridReference);
            ClickNext6Btn();
        }

        //public void FillInPropertyTypesForm()
        //{
        //    ClickNext7Btn();
        //}

        //public void FillInAdditionalDetailsForm()
        //{
        //    ClickNext8Btn();
        //}

        //public void FillInSupportingDocumentsForm()
        //{
        //    ClickNext9Btn();
        //}

        //public void FillInSummaryForm()
        //{
        //    ClickConfirm10Btn();
        //}
    }
}
