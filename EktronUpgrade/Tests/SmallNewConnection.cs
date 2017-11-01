using EktronUpgradeSse.Pages;
using EktronUpgradeSse.Pages.OnlineApplications;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;

namespace EktronUpgradeSse.Tests.OnlineApplications
{
    class SmallNewConnection : BaseTest
    {
        string _user;
        SmallNewConnectionPage _smallNewConnectionPage;
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
            _smallNewConnectionPage = onlineApplicationsPage.NavigateToSmallNewConnectionPage();
        }

        [Test]
        [Description("Verify that a user in Mull can add an optional grid reference to a Small New Connection Application and use Back or Next buttons")]
        [Author("Marat"), QualityCentreId(7627)]
        public void SmallNewConnection_001_RegistrationReasons()
        {

            UiTest(() =>
            {
                _smallNewConnectionPage.FillInPostcodeCheckForm();
                _smallNewConnectionPage.FillInSiteAddressForm();
                _smallNewConnectionPage.FillInCorrespondenceAddressForm();
                _smallNewConnectionPage.FillInCustomerDetailsForm();
                _smallNewConnectionPage.FillInSiteContactDetailsForm();
                _smallNewConnectionPage.FillInApplicationSetupForm();
                _smallNewConnectionPage.FillInPropertyDetailsForm();
                _smallNewConnectionPage.FillInAdditionalLoadForm();
                _smallNewConnectionPage.FillInSupportingDocumentsForm();
                _smallNewConnectionPage.FillInSummaryForm();
                _smallNewConnectionPage.ClickFinishBtn();
                Assert.That(_myProfilePage.MakeApplicationBtn.Displayed);
            });
        }
    }
}
