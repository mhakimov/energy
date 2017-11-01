using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace EktronUpgradeSse.Pages
{
    class PriorityServicesRegistrationPage
    {
        private IWebDriver driver;
        private Methods _methods;

        public PriorityServicesRegistrationPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            _methods = new Methods(driver);
        }
                                        //ctl00_BodyPlaceHolder_ctl00_FirstName_FirstNameFormTextBox
        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_FirstName_FirstNameFormTextBox")]
        public IWebElement FirstNameTxf { get; set; }

        [FindsBy(How = How.Name, Using = "ctl00$BodyPlaceHolder$ctl00$MedicalEquipmentType$MedicalEquipmentTypeFormTextBox")]
        public IWebElement MedicalEquipmentTypeTxf { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_OtherInformation_OtherInformationFormTextBox")]
        public IWebElement ExtraSupportReasonTxf { get; set; }


        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_MedicalEquipment_MedicalEquipmentFormCheckBox")]
        public IWebElement OtherElectricalEquipmentChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_MedicalEquipmentType_MedicalEquipmentTypeFormCustomValidator")]
        public IWebElement SpecifyMedicalEquipmentTx { get; set; }
        
        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_OtherInformation_OtherInformationFormCustomValidator")]
        public IWebElement OtherIsRequiredTx { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_OtherInformation_OtherInformationFormRegExValidator")]
        public IWebElement InvalidCharacterInOtherInfoTx { get; set; }



        [FindsBy(How = How.Name, Using = "ctl00$BodyPlaceHolder$ctl00$SubmitPriorityServicesButton$SubmitFormButton")]
        public IWebElement SubmitBtn { get; set; }

        

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_Blind_BlindFormCheckBox")]
        public IWebElement BlindChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_PartiallySighted_PartiallySightedFormCheckBox")]
        public IWebElement PartiallySightedChb { get; set; }
         
        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_Deaf_DeafFormCheckBox")]
        public IWebElement DeafChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_HardOfHearing_HardOfHearingFormCheckBox")]
        public IWebElement MentalHealthChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_StairLift_StairLiftFormCheckBox")]
        public IWebElement StairLiftChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_BathHoist_BathHoistFormCheckBox")]
        public IWebElement RestrictedMovementChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_Over60_Over60FormCheckBox")]
        public IWebElement Over60Chb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_PhysicalImpairment_PhysicalImpairmentFormCheckBox")]
        public IWebElement PhysicalImpairmentChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_HaveSpeechDifficulties_HaveSpeechDifficultiesFormCheckBox")]
        public IWebElement MedicalRefrigerationChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_Dementia_DementiaFormCheckBox")]
        public IWebElement DementiaChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_FamiliesWithChildrenUnder5_FamiliesWithChildrenUnder5FormCheckBox")]
        public IWebElement FamiliesWithChildrenChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_LearningDifficulties_LearningDifficultiesFormCheckBox")]
        public IWebElement DevelpmentConditionChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_RestrictedMovement_RestrictedMovementFormCheckBox")]
        public IWebElement TemporaryYoungAdultChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_ChronicIllness_ChronicIllnessFormCheckBox")]
        public IWebElement ChronicIlnessChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_ShortTermIllness_ShortTermIllnessFormCheckBox")]
        public IWebElement TemporaryPostHospitalRecoveryChb { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_BodyPlaceHolder_ctl00_OtherReason_OtherReasonFormCheckBox")]
        public IWebElement TemporaryLifeChangesChb { get; set; }




        public void TypeTextInFirstNameTxf(string value)
        {
            _methods.ScrollIntoView(FirstNameTxf);
            _methods.TypeInText(FirstNameTxf, value);
        }

        public void TypeTextInMedicalEquipmentTypeTxf(string value)
        {
            _methods.ScrollIntoView(MedicalEquipmentTypeTxf);
            _methods.TypeInText(MedicalEquipmentTypeTxf, value);
        }

        public void TypeTextInExtraSupportReasonTxf(string value)
        {
            _methods.TypeInText(ExtraSupportReasonTxf, value);
        }

        public void ClickOtherElectricalEquipmentChb()
        {
            _methods.ClickAt(OtherElectricalEquipmentChb);
        }

        public void ClickSubmitBtn()
        {
        //    _methods.ScrollIntoView(SubmitBtn);
            _methods.ClickAt(SubmitBtn);
        }

        public void ClickChronicIllnessChb()
        {
       //     _methods.ScrollIntoView(ChronicIlnessChb);
            _methods.ClickAt(ChronicIlnessChb);
        }


    }
}
