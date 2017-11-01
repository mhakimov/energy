using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;


namespace EktronUpgradeSse.Pages.OnlineApplications
{
    class UnmeteredConnectionPage : BaseOnlineApplicationPage
    {

        public UnmeteredConnectionPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
          applicationName = "UnmeteredContents";
        }


        [FindsBy(How = How.XPath, Using = "//div[4]/div[3]/div/img")]
        public IWebElement PinImg { get; set; }

        public IWebElement HavePlacedMyPinChb()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_ctl00_ConfirmPinLocation_CheckModifiedLatLongFormCheckBox", applicationName)));
        }

        public IWebElement ApplicantTypeDdm()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_ApplicantType_ApplicantTypeFormDropDownList", applicationName)));
        }

        public IWebElement NumberOfNewConnections()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_NumberOfNewConnections_NumberOfNewConnectionsFormTextBox", applicationName)));
        }

    



        public void ClickHavePlacedMyPinChb()
        {
            _methods.ClickAt(HavePlacedMyPinChb());
        }

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


        public void FillInGeneralRequirementsForm(string applicant = "1", string numberOfConnections = "2", string numberOfTransfers = "1", string numberOfDisconnections = "2", string gridReference = "SU1234512345",
            string jobDescription = "automation test")
        {
            new SelectElement(ApplicantTypeDdm()).SelectByValue(applicant);
            _methods.TypeInText(NumberOfNewConnections(), numberOfConnections);
            _methods.TypeInText(NumberOfTransfers(), numberOfTransfers);
            _methods.TypeInText(NumberOfDisconnections(), numberOfDisconnections);
            _methods.TypeInText(GridReferenceTxf(), gridReference);
            _methods.TypeInText(JobDescriptionTxf(), numberOfTransfers);
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
