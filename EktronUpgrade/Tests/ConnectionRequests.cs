using EktronUpgradeSse.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Tests
{
    class ConnectionRequests : BaseTest
    {
        AlternativeProviderRegistrationPage _alternativeProviderRegistrationPage;
        string _independentConsultant = "Independent Consultant";
        string _mcdonalds = "McDonalds";
        string _address = "5 Elm Street";
        string _phoneNumber = "01234222333";
        string _email = "marat.ceo@amazon.com";


        [OneTimeSetUp]
        public void FixtureSetup()
        {

        }

        [SetUp]
        public void Start()
        {
            HomePage homePage = new HomePage(driver);
            CompetitionInConnectionsPage competitionInConnectionPage = homePage.NavigateToCompetitionInConnectionsPage();
            _alternativeProviderRegistrationPage =
               competitionInConnectionPage.NavigateToAlternativeProviderRegistrationPage();
        }

        [Test]
        [Description("Verify the customer can view the services the AP offers")]
        [Author("Marat"), QualityCentreId(7641)]
        public void CompetitionInConnections_01_ApServicesAreVisible()
        {
            UiTest(() =>
            {
                _alternativeProviderRegistrationPage.FillInYourCompanyDetails(_independentConsultant, name: _mcdonalds, address: _address, number: _phoneNumber, email: _email);

                _alternativeProviderRegistrationPage.TickTheAreasAndActivities(new IWebElement[]{_alternativeProviderRegistrationPage.HighlandsChb,
                _alternativeProviderRegistrationPage.OrkneyChb,
                _alternativeProviderRegistrationPage.WesternIslesChb,
                _alternativeProviderRegistrationPage.OxfordChb,
                _alternativeProviderRegistrationPage.ExtraHighVoltageOverheadChb,
                _alternativeProviderRegistrationPage.UnmeteredChb});

                var highlands = _alternativeProviderRegistrationPage.HighlandsChb.Text;
                var orkney = _alternativeProviderRegistrationPage.OrkneyChb.Text;
                var westernIsles = _alternativeProviderRegistrationPage.WesternIslesChb.Text;
                var oxford = _alternativeProviderRegistrationPage.OxfordChb.Text;
                var extraVoltageOverhead = _alternativeProviderRegistrationPage.ExtraHighVoltageOverheadChb.Text;
                var unmetered = _alternativeProviderRegistrationPage.UnmeteredChb.Text;

                _alternativeProviderRegistrationPage.ClickRegisterBtn();

                var scotlandAreas = _alternativeProviderRegistrationPage.ScotlandRegionsTx.Text.Replace("Scotland\r\n", "");
                var englandAreas = _alternativeProviderRegistrationPage.EnglandRegionsTx.Text.Replace("England\r\n", "");
                var activities = _alternativeProviderRegistrationPage.TheActivitiesYouWishToEngageInTx.Text.Replace("The Activites you wish to engage in:\r\n", "");

                Assert.That(_alternativeProviderRegistrationPage.CompanyTypeValueTx.Text, Is.EqualTo(_independentConsultant));
                Assert.That(_alternativeProviderRegistrationPage.CompanyNameValueTx.Text, Is.EqualTo(_mcdonalds));
                Assert.That(_alternativeProviderRegistrationPage.AddressValueTx.Text, Is.EqualTo(_address));
                Assert.That(_alternativeProviderRegistrationPage.PhoneNumberValueTx.Text, Is.EqualTo(_phoneNumber));
                Assert.That(_alternativeProviderRegistrationPage.EmailAddressValueTx.Text, Is.EqualTo(_email));

                Assert.That(scotlandAreas, Is.EqualTo(string.Format("{0}, {1}, {2}", highlands, orkney, westernIsles)));
                Assert.That(englandAreas, Is.EqualTo(oxford));
                Assert.That(activities, Is.EqualTo(string.Format("{0}, {1}", extraVoltageOverhead, unmetered)));
            });
          
        }
    }
}
