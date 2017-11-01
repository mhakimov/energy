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
    class UnmeteredConnection :BaseTest
    {
        string _user;
        UnmeteredConnectionPage _unmeteredConnectionPage;
        UnmeteredSuppliesPage _unmeteredSuppliesPage;
        MyProfilePage _myProfilePage;


        [SetUp]
        public void Start()
        {
            _user = Methods.SelectRandomElement(_emails);
            HomePage homePage = new HomePage(driver);
            SignInPage signInPage = homePage.NavigateToSignInPage();
            signInPage.TypeTextInEmailAddressTxf(_user);
            signInPage.TypeTextInPasswordTxf(_password);
            _unmeteredSuppliesPage = signInPage.NavigateToMyProfilePage().NavigateToOnlineApplicationsPage().NavigateToUnmeteredSuppliesPage();
        }

        [Test]
        [Description("Verify a PSR application cannot be completed without specifying MED")]
        [Author("Marat"), QualityCentreId(7634)]
        public void UnmeteredConnection_01_DistributedGeneration()
        {
            UiTest(() =>
            {
                _unmeteredConnectionPage = _unmeteredSuppliesPage.NavigateToUnmeteredConnectionPage();
                _unmeteredConnectionPage.FillInPostcodeCheckForm();
                _unmeteredConnectionPage.FillInSiteAddressForm();
                _unmeteredConnectionPage.FillInCorrespondenceAddressForm();
                _unmeteredConnectionPage.FillInCustomerDetailsForm();
                _unmeteredConnectionPage.FillInSiteContactDetailsForm();
                _unmeteredConnectionPage.FillInGeneralRequirementsForm("1", "5", "2", "3");
                _unmeteredConnectionPage.FillInSupportingDocumentsForm();
                _unmeteredConnectionPage.FillInSummaryForm();
                _myProfilePage = _unmeteredConnectionPage.ClickFinishBtn();
                Assert.That(_myProfilePage.MakeApplicationBtn.Displayed);
            });
        }


    }
}
