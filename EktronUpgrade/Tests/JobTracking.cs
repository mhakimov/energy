using EktronUpgradeSse.Pages;
using NUnit.Framework;
using System;

namespace EktronUpgradeSse.Tests
{

    class JobTracking : BaseTest
    {
       

        [SetUp]
        public void Start()
        {
            HomePage homePage = new HomePage(driver);
            SignInPage signInPage = homePage.NavigateToSignInPage();
            signInPage.TypeTextInEmailAddressTxf(Methods.SelectRandomElement(_emails));
            signInPage.TypeTextInPasswordTxf(_password);
            MyProfilePage myProfilePage = signInPage.NavigateToMyProfilePage();
            JobTrackingPage jobTrackingPage = myProfilePage.NavigateToJobTrackingPage();
         
        }

      
    }
}
