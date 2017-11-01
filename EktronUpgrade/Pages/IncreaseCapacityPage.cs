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
    class IncreaseCapacityPage : BaseOnlineApplicationPage
    {

        public IncreaseCapacityPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
            applicationName = "IncreaseCapacityContents";
        }



        public IWebElement PleaseDescribeTypeOfWorkTxf()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_PropertyWorkDescription_PropertyWorkDescriptionFormTextBox", applicationName)));
        }

        public IWebElement ElectricBoilerQuantity()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_ElectricBoilerFormDualTextBox_TextBox1_ElectricHeatingNumberElectricBoilerFormTextBox", applicationName)));
        }

        public IWebElement ElectricBoilerKw()
        {
            return driver.FindElement(By.Id(string.Format("ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_{0}_ctl00_ElectricBoilerFormDualTextBox_TextBox2_ElectricHeatingRatingElectricBoilerFormTextBox", applicationName)));
        }






        public void FillInPropertyDetailsForm(string typeOfWork = "automation test", string electricBoilerQty = "1",
         string electricBoilerKw = "10")
        {
            _methods.TypeInText(PleaseDescribeTypeOfWorkTxf(), typeOfWork);
            _methods.TypeInText(ElectricBoilerQuantity(), electricBoilerQty);
            _methods.TypeInText(ElectricBoilerKw(), electricBoilerKw);
            ClickNext7Btn();
        }





        public void FillInApplicationSetupForm()
        {
            _methods.ClickAt(Next6Btn);
        }

    

        public void FillInMainsDiversionForm(string generalDescription = "automation description", string gridReference = "NH1234512345")
        {
            _methods.ClickAt(UndergroundCablesChb());
            _methods.TypeInText(GeneralDescriptionTxf(), generalDescription);
            _methods.TypeInText(GridReferenceTxf(), gridReference);
            _methods.ClickAt(Next6Btn);
        }

    }
}
