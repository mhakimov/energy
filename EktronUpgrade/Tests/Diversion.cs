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
    class Diversion : BaseTest
    {
        string _user;
        DiversionPage _diversionPage;
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
            _diversionPage = onlineApplicationsPage.NavigateToDiversionPage();
        }

        [Test]
        [Description("Submit the application and receive a PROMIS ref number")]
        [Author("Marat"), QualityCentreId(7629)]
        public void Diversion_01_SubmitApplication()
        {
            UiTest(() =>
            {
                _diversionPage.FillInPostcodeCheckForm();
                _diversionPage.FillInSiteAddressForm();
                _diversionPage.FillInCorrespondenceAddressForm();
                _diversionPage.FillInCustomerDetailsForm();
                _diversionPage.FillInSiteContactDetailsForm();
                _diversionPage.FillInMainsDiversionForm();
                _diversionPage.FillInSupportingDocumentsForm();
                _diversionPage.FillInSummaryForm();
                _diversionPage.ClickFinishBtn();
                Assert.That(_myProfilePage.MakeApplicationBtn.Displayed);
            });
        }
    }
}
