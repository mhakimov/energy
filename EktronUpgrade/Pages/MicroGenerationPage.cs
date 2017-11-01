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
    class MicroGenerationPage : BaseOnlineApplicationPage
    {       
        public MicroGenerationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
            applicationName = "MicroGenerationContents";
        }

        public void FillInSupportingDocumentsForm()
        {
            ClickNext8Btn();
        }

        public void FillInSummaryForm()
        {
            _methods.ClickAt(Confirm9Btn);
        }

    }
}
