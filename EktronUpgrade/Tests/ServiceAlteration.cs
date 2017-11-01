using EktronUpgradeSse.Pages;
using EktronUpgradeSse.Pages.OnlineApplications;
using NUnit.Framework;

namespace EktronUpgradeSse.Tests.OnlineApplications
{
    class ServiceAlteration : BaseTest
    {
        string _user;
        ServiceAlterationPage _serviceAlterationPage;
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
            _serviceAlterationPage = onlineApplicationsPage.NavigateToServiceAlterationPage();
        }

        [Test]
        [Description("Verify a PSR application cannot be completed without specifying MED")]
        [Author("1 Marat")]
        public void _001_ServiceAlteration_RegistrationReasons()
        {
            UiTest(() =>
            {
                _serviceAlterationPage.FillInPostcodeCheckForm();
                _serviceAlterationPage.FillInSiteAddressForm();
                _serviceAlterationPage.FillInCorrespondenceAddressForm();
                _serviceAlterationPage.FillInCustomerDetailsForm();
                _serviceAlterationPage.FillInSiteContactDetailsForm();
                _serviceAlterationPage.FillInGeneralRequirementsForm();
                _serviceAlterationPage.FillInSupportingDocumentsForm();
                _serviceAlterationPage.FillInSummaryForm();
                Assert.That(_serviceAlterationPage.ReferenceNumberTx.Displayed);
                _serviceAlterationPage.ClickFinishBtn();
                Assert.That(_myProfilePage.MakeApplicationBtn.Displayed);
            });

        }
    }
}
