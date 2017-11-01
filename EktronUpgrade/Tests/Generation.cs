using EktronUpgradeSse.Pages;
using EktronUpgradeSse.Pages.OnlineApplications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Tests.OnlineApplications
{
    class Generation :BaseTest
    {
        string _user;
        GenerationPage _generationPage;
        MyProfilePage _myProfilePage;
        DistributedGenerationPage _distributedGenerationPage;
        MicroGenerationPage _microGenrationPage;


        [SetUp]
        public void Start()
        {
            _user = Methods.SelectRandomElement(_emails);
            HomePage homePage = new HomePage(driver);
            SignInPage signInPage = homePage.NavigateToSignInPage();
            signInPage.TypeTextInEmailAddressTxf(_user);
            signInPage.TypeTextInPasswordTxf(_password);
            _myProfilePage = signInPage.NavigateToMyProfilePage();
            OnlineApplicationsPage onlineApplicationsPage = _myProfilePage.NavigateToOnlineApplicationsPage();
            _generationPage = onlineApplicationsPage.NavigateToGenerationPage();
        }

        [Test]
        [Description("Verify a PSR application cannot be completed without specifying MED")]
        [Author("Marat")]
        public void Generation_01_DistributedGeneration()
        {
            UiTest(() =>
            {
                _distributedGenerationPage = _generationPage.NavigateToDistributedGenerationPage();
                _distributedGenerationPage.FillInPostcodeCheckForm();
                _distributedGenerationPage.FillInSiteAddressForm();
                _distributedGenerationPage.FillInCorrespondenceAddressForm();
                _distributedGenerationPage.FillInCustomerDetailsForm();
                _distributedGenerationPage.FillInSiteContactDetailsForm();
                _distributedGenerationPage.FillInApplicationDetailsForm();
                _distributedGenerationPage.FillInSupportingDocumentsForm();
                _distributedGenerationPage.FillInSummaryForm();
                _distributedGenerationPage.ClickFinishBtn();
                Assert.That(_myProfilePage.MakeApplicationBtn.Displayed);
            });
        }


        [Test]
        [Description("Verify a PSR application cannot be completed without specifying MED")]
        [Author("Marat")]
        public void Generation_02_MicroGeneration()
        {
            UiTest(() =>
            {
                _microGenrationPage = _generationPage.NavigateToMicroGenerationPage();
                _microGenrationPage.FillInPostcodeCheckForm();
                _microGenrationPage.FillInSiteAddressForm();
                _microGenrationPage.FillInCorrespondenceAddressForm();
                _microGenrationPage.FillInCustomerDetailsForm();
                _microGenrationPage.FillInSiteContactDetailsForm();
                _microGenrationPage.FillInApplicationDetailsForm();
                _microGenrationPage.FillInSupportingDocumentsForm();
                _microGenrationPage.FillInSummaryForm();
                _microGenrationPage.ClickFinishBtn();
                Assert.That(_myProfilePage.MakeApplicationBtn.Displayed);
            });
        }
    }
}
