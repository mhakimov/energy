using EktronUpgradeSse.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;


namespace EktronUpgradeSse.Tests
{
    class Events : BaseTest
    {
        EventsPage _eventsPage;
        AdvancedSearchPage _advancedSearchPage;
        ContactOrganiserPage _contactOrganiserPage;
        MyProfilePage _myProfilePage;
        EventRegisterationPage _eventRegisterationPage;



        [SetUp]
        public void Start()
        {
            HomePage homePage = new HomePage(driver);
            SignInPage signInPage = homePage.NavigateToSignInPage();
            signInPage.TypeTextInEmailAddressTxf(Methods.SelectRandomElement(_emails));
            signInPage.TypeTextInPasswordTxf(_password);
             _myProfilePage = signInPage.NavigateToMyProfilePage();
        }



        [Test]
        [Description("Verify all buttons display the correct pages - Multi-day")]
        [Author("Marat"), QualityCentreId(7647)]
        public void Events_01_EventsCalendar()
        {
            UiTest(() =>
            {
                _eventsPage = _myProfilePage.NavigateToEventsPage();

                Assert.That(_eventsPage.Calendar.Displayed);
                Assert.That(_eventsPage.Calendar.Enabled);

                _eventsPage.ClickFutureEvent();
                Assert.That(_eventsPage.GetStartDate().Displayed);
                Assert.That(_eventsPage.GetStartDate().Text, Is.Not.Empty);

                _eventRegisterationPage = _eventsPage.ClickRegisterNow();
                Assert.That(_eventRegisterationPage.RegisterYourDetailsTx.Displayed);

                driver.Navigate().Back();
                _advancedSearchPage = _eventsPage.ClickAdvancedSearch();
                Assert.That(_advancedSearchPage.SearchResultsTx.Displayed);

                driver.Navigate().Back();
                Assert.That(_eventsPage.Calendar.Displayed);
            });
        }


        [Test]
        [Description("Verify the user can complete an advanced search")]
        [Author("Marat"), QualityCentreId(7642)]
        public void Events_02_AdvancedSearch()
        {
            UiTest(() =>
            {
                _eventsPage = _myProfilePage.NavigateToEventsPage();

                _advancedSearchPage = _eventsPage.ClickAdvancedSearch();

                _advancedSearchPage.TypeInDateFrom(string.Format("{0:d}", DateTime.Now.AddYears(-1)));
                _advancedSearchPage.TypeInDateTo(string.Format("{0:d}", DateTime.Now.AddYears(1)));

                _advancedSearchPage.ChooseCategoriesAndRegions(new IWebElement[] {_advancedSearchPage.ConnectionsChb, _advancedSearchPage.ReliabilityChb, _advancedSearchPage.EnvironmentChb,
            _advancedSearchPage.EnglandChb});

                _advancedSearchPage.ClickSearch();
                Assert.That(_advancedSearchPage.EventNameTx.Displayed);
                Assert.That(_advancedSearchPage.EventDateTx.Displayed);
                Assert.That(_advancedSearchPage.EventDescriptionTx.Displayed);
                Assert.That(_advancedSearchPage.ContactOrganiserBtn.Displayed);
                Assert.That(_advancedSearchPage.ContactOrganiserBtn.Enabled);
            });
        }


        [Test]
        [Description("Verify the user can contact the organiser")]
        [Author("Marat"), QualityCentreId(7643)]
        public void Events_03_ContactOrganiser()
        {
            UiTest(() =>
            {
                _eventsPage = _myProfilePage.NavigateToEventsPage();

                _contactOrganiserPage = _eventsPage.ClickContactOrganiser();
                _contactOrganiserPage.CheckThatAllDetailsAreEnabled();

                _contactOrganiserPage.FillInTheFormAndSendMessage();
                Assert.That(_contactOrganiserPage.EmailSentTx.Displayed);
            });
        }


        [Test]
        [Description("verify the user can view the list of events they are registered for - Multi-day")]
        [Author("Marat"), QualityCentreId(7651)]
        public void Events_04_RegisteredEvents()
        {
            UiTest(() =>
            {
                string eventName;
                if (_myProfilePage.UpcomingEventsTx.Text.Contains("You are not currently registered to attend any events."))
                {
                    _eventsPage = _myProfilePage.ClickViewAllEventsBtn();
                    _eventsPage.ClickFutureEvent();
                    _eventRegisterationPage = _eventsPage.ClickRegisterNow();
                    _eventRegisterationPage.FillInRegistrationForm();
                    Assert.That(_eventRegisterationPage.ThankYouForRegisteringTx.Text, Is.EqualTo("Thank you for registering. You should receive an email shortly confirming this."));
                    eventName = _eventRegisterationPage.EventNameTx.Text;
                    _eventRegisterationPage.NavigateToMyProfilePageWhenSignedIn();
                    Assert.That(_myProfilePage.EventHeadingTx.Text, Is.EqualTo(eventName));
                    _myProfilePage.ClickCancelRegistrationBtn();
                }

                else
                    Assert.That(_myProfilePage.EventHeadingTx.Displayed);
            });

        }
    }
}
