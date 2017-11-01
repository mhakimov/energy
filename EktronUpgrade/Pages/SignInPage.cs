using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Pages
{
    class SignInPage
    {
        public IWebDriver driver;
        public Methods _methods;

        public SignInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_signInControl_UserName_UserNameFormTextBox")]
        public IWebElement EmailAddressTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_signInControl_Password_PasswordFormTextBox")]
        public IWebElement PasswordTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_BodyPlaceHolder_BodyPlaceHolder_signInControl_SignInSubmitButton_SignInButtonFormButton")]
        public IWebElement SignInBtnOnSignInPage { get; set; }




        public void TypeTextInEmailAddressTxf(string value)
        {
            try
            {
                _methods.TypeInText(EmailAddressTxf, value);
            }
            catch (NoSuchElementException)
            {
                Task.Delay(2000);
                _methods.TypeInText(EmailAddressTxf, value);
            }

        }

        public void TypeTextInPasswordTxf(string value)
        {
            _methods.TypeInText(PasswordTxf, value);
        }

        public MyProfilePage NavigateToMyProfilePage()
        {
            _methods.ClickAt(SignInBtnOnSignInPage);
            return new MyProfilePage(driver);
        }


        //public void ClickAccountBtn()
        //{
        //    _methods.ClickAt(AccountBtn);
        //}



    }
}
