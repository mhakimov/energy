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
    class DiversionPage : BaseOnlineApplicationPage
    {
       // public string applicationName = "DiversionContents";

        public DiversionPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
            applicationName = "DiversionContents";
        }






        [FindsBy(How = How.XPath, Using = "//div[4]/div[3]/div/img")]
        public IWebElement PinImg { get; set; }

     


    


        public IWebElement HavePlacedMyPinChb()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_ctl00_ConfirmPinLocation_CheckModifiedLatLongFormCheckBox", applicationName)));
        }

  



        public void ClickHavePlacedMyPinChb()
        {
            _methods.ClickAt(HavePlacedMyPinChb());
        }

        //public void ClickNextBtn()
        //{
        //    _methods.ClickAt(NextBtn);
        //}

        //public void ClickNext3Btn()
        //{
        //    _methods.ClickAt(Next3Btn);
        //}

        //public void ClickNext4Btn()
        //{
        //    _methods.ClickAt(Next4Btn);
        //}

        //public void ClickNext5Btn()
        //{
        //    _methods.ClickAt(Next5Btn);
        //}

        //public void ClickNext6Btn()
        //{
        //    _methods.ClickAt(Next6Btn);
        //}

        //public void ClickNext7Btn()
        //{
        //    _methods.ClickAt(Next7Btn);
        //}

        //public void ClickNext8Btn()
        //{
        //    _methods.ClickAt(Next8Btn);
        //}

        //public void ClickNext9Btn()
        //{
        //    _methods.ClickAt(Next9Btn);
        //}

        //public void ClickUseMyContactDetailsBtn()
        //{
        //    _methods.ClickAt(UseMyContactDetailsBtn());
        //}

        //public void ClickConfirmBtn()
        //{
        //    _methods.ClickAt(ConfirmBtn);
        //}

        //public void ClickConfirm10Btn()
        //{
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

        //[FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_ServiceAlterationContents_ctl00_ctl00_mapDiv']/div/div/div[1]/div[3]/div")]
        //public IWebElement MapFrame2 { get; set; }

        public void FillInSiteAddressForm(string propertyNumber = "1", string address = "Walton Park")
        {
            _methods.ClickAt(PinImg);
            Actions act = new Actions(driver);
            act.DragAndDrop(PinImg, MapFrame()).Build().Perform();
            ClickHavePlacedMyPinChb();
            _methods.TypeInText(PropertyNumberTxf(), propertyNumber);
            _methods.TypeInText(AddressTxf(), address);
            ClickNextBtn();
        }

        //public void FillInCorrespondenceAddressForm(string postcode = "LU1 1LN", string phoneNumber = "01473223344")
        //{
        //    _methods.TypeInText(PostcodeSearchTxf(), postcode);
        //    _methods.ClickAt(FindAddressBtn());
        //    _methods.ClickAt(AddressFirstOption());
        //    ClickUseMyContactDetailsBtn();
        //    if (PhoneNumberTxf().GetAttribute("value").Length<1)
        //    _methods.TypeInText(PhoneNumberTxf(), phoneNumber);
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
        //    _methods.TypeInText(NameOfSiteContactTxf(), nameOfContact);
        //    _methods.TypeInText(PhoneNumberForSiteContactTxf(), phoneNumber);
        //    _methods.TypeInText(EmailForSiteContactTxf(), email);
        //    ClickNext5Btn();
        //}

        public void FillInMainsDiversionForm(string generalDescription = "automation description", string gridReference = "NH1234512345")
        {
            _methods.ClickAt(UndergroundCablesChb());
            _methods.TypeInText(GeneralDescriptionTxf(), generalDescription);
            _methods.TypeInText(GridReferenceTxf(), gridReference);
            _methods.ClickAt(Next6Btn);
        }

        //public void FillInPropertyDetailsForm(string typeOfWork = "automation test", string totalLoad = "12", string numberOfBedrooms = "2", string electricBoilerQty = "1",
        //    string electricBoilerKw = "10", string gridReference = "NH1234512345")
        //{
        //    _methods.TypeInText(PleaseDescribeTypeOfWorkTxf(), typeOfWork);
        //    _methods.TypeInText(PleaseEnterTotalLoadTxf(), totalLoad);
        //    _methods.TypeInText(NumberOfBedrooms(), numberOfBedrooms);
        //    _methods.TypeInText(ElectricBoilerQuantity(), electricBoilerQty);
        //    _methods.TypeInText(ElectricBoilerKw(), electricBoilerKw);
        //    ClickNext7Btn();
        //}

        //public void FillInAdditionalLoadForm()
        //{
        //    ClickNext8Btn();
        //}

        //public void FillInAdditionalDetailsForm()
        //{
        //    ClickNext8Btn();
        //}

        public void FillInSupportingDocumentsForm()
        {
            ClickNext7Btn();
        }

        public void FillInSummaryForm()
        {
            _methods.ClickAt(ConfirmBtn);
        }
    }
}
