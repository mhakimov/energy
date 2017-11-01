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
    class IncreaseCapacity : BaseTest
    {
        string _user;
        IncreaseCapacityPage _increaseCapacityPage;
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
            _increaseCapacityPage = onlineApplicationsPage.NavigateToIncreaseCapacityPage();
        }

        [Test]
        [Description("Submit the application and receive a PROMIS ref number")]
        [Author("Marat"), QualityCentreId(7629)]
        public void IncreaseCapacity_01_SubmitApplication()
        {
            UiTest(() =>
            {
                _increaseCapacityPage.FillInPostcodeCheckForm();
                _increaseCapacityPage.FillInSiteAddressForm();
                _increaseCapacityPage.FillInCorrespondenceAddressForm();
                _increaseCapacityPage.FillInCustomerDetailsForm();
                _increaseCapacityPage.FillInSiteContactDetailsForm();
                _increaseCapacityPage.FillInApplicationSetupForm("123456789");
                _increaseCapacityPage.FillInPropertyDetailsForm();
                _increaseCapacityPage.FillInAdditionalLoadForm();
                _increaseCapacityPage.FillInSupportingDocumentsForm();
                _increaseCapacityPage.FillInSummaryForm();
                _increaseCapacityPage.ClickFinishBtn();
                Assert.That(_myProfilePage.MakeApplicationBtn.Displayed);
            });
        }
    }
}
