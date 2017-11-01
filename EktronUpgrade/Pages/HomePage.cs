using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class HomePage : BasePage
    {

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        public void ClickMenuBtn()
        {
            _methods.ClickAt(MenuBtn);
        }

        public void ClickPowerCutsBtn()
        {
            _methods.ClickAt(PowerCutsBtn);
        }

        public void ClickPriorityServicesBtn()
        {
            _methods.ClickAt(PriorityServicesBtn);
        }


        public void NavigateToPowerCutsBtn()
        {
            MakeMenuAppear();
            ClickPowerCutsBtn();
        }

        public void NavigateToConnectionsBtn()
        {
            MakeMenuAppear();
        }

        public PriorityServicesPage NavigateToPriorityServicesPage()
        {
            NavigateToPowerCutsBtn();
            ClickPriorityServicesBtn();
            return new PriorityServicesPage(driver);
        }


    }
}
