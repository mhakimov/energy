using EktronUpgradeSse.Pages;
using EktronUpgradeSse.Pages.OnlineApplications;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace EktronUpgradeSse.Tests.OnlineApplications
{
    class LargeNewConnection : BaseTest
    {
        string _user;
        LargeNewConnectionPage _largeNewConnectionPage;
        MyProfilePage _myProfilePage;


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
            _largeNewConnectionPage = onlineApplicationsPage.NavigateToLargeNewConnectionPage();
        }

        [Test]
        [Description("Verify a PSR application cannot be completed without specifying MED")]
        [Author("1 Marat")]
        public void LargeNewConnection_001_RegistrationReasons()
        {
            UiTest(() =>
            {
                _largeNewConnectionPage.FillInPostcodeCheckForm();
                _largeNewConnectionPage.FillInSiteAddressForm();
                _largeNewConnectionPage.FillInCorrespondenceAddressForm();
                _largeNewConnectionPage.FillInCustomerDetailsForm();
                _largeNewConnectionPage.FillInSiteContactDetailsForm();
                _largeNewConnectionPage.FillInGeneralRequirementsForm();
                _largeNewConnectionPage.FillInPropertyTypesForm();
                _largeNewConnectionPage.FillInAdditionalDetailsForm();
                _largeNewConnectionPage.FillInSupportingDocumentsForm();
                _largeNewConnectionPage.FillInSummaryForm();
                _largeNewConnectionPage.ClickFinishBtn();
                Assert.That(_myProfilePage.MakeApplicationBtn.Displayed);
            });
        }
    }
}
