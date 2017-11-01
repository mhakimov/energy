using EktronUpgradeSse.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EktronUpgradeSse.Tests
{
    class PriorityServicesRegistration : BaseTest
    {
        PriorityServicesRegistrationPage _priorityServicesRegistrationPage;


        [SetUp]
        public void Start()
        {
            HomePage homePage = new HomePage(driver);
            PriorityServicesPage priorityServicesPage = homePage.NavigateToPriorityServicesPage();
             _priorityServicesRegistrationPage =
                priorityServicesPage.NavigateToPriorityServicesRegistrationPage();
        }


        [Test]
        [Description("Verify a PSR application cannot be completed without specifying MED")]
        [Author("1 Marat")]
        public void _001_PsrApplication_RegistrationReasons()
        {
            UiTest(()=> {
                _priorityServicesRegistrationPage.TypeTextInFirstNameTxf("Test");
                _priorityServicesRegistrationPage.ClickOtherElectricalEquipmentChb();
                try
                {
                    _priorityServicesRegistrationPage.ClickSubmitBtn();
                }
                catch (OpenQA.Selenium.WebDriverException)
                {

                }

                _priorityServicesRegistrationPage.TypeTextInMedicalEquipmentTypeTxf("electronic cigarette");
                _priorityServicesRegistrationPage.ClickSubmitBtn();
                Assert.That(_priorityServicesRegistrationPage.SpecifyMedicalEquipmentTx.Displayed);
            });
           
        }


        [Test]
        [Description("Verify a PSR application registration reason checkboxes are present and clickable")]
        [Author("1 Marat")]
        public void _002_PsrApplication_RegistrationReasonsCheckboxes()
        {
            Assert.That(_priorityServicesRegistrationPage.BlindChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.PartiallySightedChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.DeafChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.MentalHealthChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.StairLiftChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.RestrictedMovementChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.Over60Chb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.PhysicalImpairmentChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.MedicalRefrigerationChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.DementiaChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.FamiliesWithChildrenChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.DevelpmentConditionChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.TemporaryYoungAdultChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.ChronicIlnessChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.TemporaryPostHospitalRecoveryChb.Enabled);
            Assert.That(_priorityServicesRegistrationPage.TemporaryLifeChangesChb.Enabled);
        }


        [Test]
        [Description("Verify a PSR application cannot be completed without specifying a need for extra support")]
        [Author("1 Marat")]
        public void _003_PsrApplication_RegistrationReasonsForExtraSupport()
        {
            _priorityServicesRegistrationPage.ClickChronicIllnessChb();
            try
            {
                _priorityServicesRegistrationPage.ClickSubmitBtn();
            }
            catch (OpenQA.Selenium.WebDriverException)
            {

            } 
            Assert.That(_priorityServicesRegistrationPage.OtherIsRequiredTx.Displayed);

            _priorityServicesRegistrationPage.TypeTextInExtraSupportReasonTxf("test");
            _priorityServicesRegistrationPage.ClickSubmitBtn();
            Assert.That(_priorityServicesRegistrationPage.InvalidCharacterInOtherInfoTx.Displayed);

            _priorityServicesRegistrationPage.TypeTextInExtraSupportReasonTxf("er");
            _priorityServicesRegistrationPage.ClickSubmitBtn();
            Assert.That(!_priorityServicesRegistrationPage.OtherIsRequiredTx.Displayed);
            Assert.That(!_priorityServicesRegistrationPage.InvalidCharacterInOtherInfoTx.Displayed);
        }
    }
}
