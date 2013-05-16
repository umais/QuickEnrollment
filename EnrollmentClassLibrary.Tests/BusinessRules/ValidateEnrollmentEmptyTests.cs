using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnrollmentClassLibrary.BusinessRules;
using EnrollmentClassLibrary.Models;

namespace EnrollmentClassLibrary.Tests.BusinessRules
{
    /// <summary>
    /// The <c>ValidateEnrollmentTests</c> class is a unit test class for ValidateEnrollment
    /// if the field is required, then the result should be false. If the field is optional, then 
    /// the result should be true.
    /// </summary>
    [TestClass]
    public class ValidateEnrollmentEmptyTests
    {
        public static string NULL = "";
        public EnrollmentTransaction TheTransaction = new EnrollmentTransaction();
        public ValidateEnrollment TheValidationRules;

        public ValidateEnrollmentEmptyTests()
        {
            TheValidationRules = new ValidateEnrollment(TheTransaction);

            TheTransaction.ActionCode = NULL;
            TheTransaction.AddressUpdateFlag = NULL;
            TheTransaction.ApplicationDate = NULL;
            TheTransaction.BirthDate = NULL;
            TheTransaction.ContractNumber = NULL;
            TheTransaction.CreditableCoverageFlag = NULL;
            TheTransaction.DisenrollmentReason = NULL;
            TheTransaction.EffectiveDate = NULL;
            TheTransaction.EGHPFlag = NULL;
            TheTransaction.ElectionType = NULL;
            TheTransaction.EmployerSubsidyEnrollment = NULL;
            TheTransaction.EndDate = NULL;
            TheTransaction.EnrollmentSource = NULL;
            TheTransaction.ESRDOverride = NULL;
            TheTransaction.FirstName = NULL;
            TheTransaction.GenderCode = NULL;
            TheTransaction.HICN = NULL;
            TheTransaction.MInitial = NULL;
            TheTransaction.NumberofUncoveredMonths = NULL;
            TheTransaction.PartCPremiumAmount = NULL;
            TheTransaction.PartDOptOutFlag = NULL;
            TheTransaction.PartDRxBIN = NULL;
            TheTransaction.PartDRxGroup = NULL;
            TheTransaction.PartDRxId = NULL;
            TheTransaction.PartDRxPCN = NULL;
            TheTransaction.PBPNumber = NULL;
            TheTransaction.PremiumWithholdOption = NULL;
            TheTransaction.ResidenceAddress1 = NULL;
            TheTransaction.ResidenceAddress2 = NULL;
            TheTransaction.ResidenceCity = NULL;
            TheTransaction.ResidenceState = NULL;
            TheTransaction.ResidenceZipCode = NULL;
            TheTransaction.ResidenceZipCode4 = NULL;
            TheTransaction.SecondaryDrugBIN = NULL;
            TheTransaction.SecondaryDrugInsuranceFlag = NULL;
            TheTransaction.SecondaryDrugPCN = NULL;
            TheTransaction.SecondaryRxGroup = NULL;
            TheTransaction.SecondaryRxId = NULL;
            TheTransaction.SegmentId = NULL;
            TheTransaction.Surname = NULL;
            TheTransaction.TransactionID = NULL;
            TheTransaction.TransactionTrackingId = NULL;
        }

        [TestMethod]
        public void ValidateHICN_Empty()
        {
            bool Result = TheValidationRules.ValidateHICN();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateSurname_Empty()
        {
            bool Result = TheValidationRules.ValidateSurname();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateFirstName_Empty()
        {
            bool Result = TheValidationRules.ValidateFirstName();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateMInitial_Empty()
        {
            bool Result = TheValidationRules.ValidateMInitial();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateContractNumber_Empty()
        {
            bool Result = TheValidationRules.ValidateContractNumber();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateGenderCode_Empty()
        {
            bool Result = TheValidationRules.ValidateGenderCode();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateBirthDate_Empty()
        {
            bool Result = TheValidationRules.ValidateBirthDate();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateEGHPFlag_Empty()
        {
            bool Result = TheValidationRules.ValidateEGHPFlag();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateApplicationDate_Empty()
        {
            bool Result = TheValidationRules.ValidateApplicationDate();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateEffectiveDate_Empty()
        {
            bool Result = TheValidationRules.ValidateEffectiveDate();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateSegmentId_Empty()
        {
            bool Result = TheValidationRules.ValidateSegmentId();
            Assert.AreEqual(false, Result);
        }

        /// <summary>
        /// The ESRD Override is required for MA plans to enroll ESRD exceptions. For this
        /// version of the software, this field is assumed to be required in all cases.
        /// This test case should be modified when plan types are available.
        /// </summary>
        [TestMethod]
        public void ValidateESRDOverride_Empty()
        {
            bool Result = TheValidationRules.ValidateESRDOverride();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidatePremiumWithholdOption_Empty()
        {
            bool Result = TheValidationRules.ValidatePremiumWithholdOption();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePartCPremiumAmount_Empty()
        {
            bool Result = TheValidationRules.ValidatePartCPremiumAmount();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateCreditCoverageFlag_Empty()
        {
            bool Result = TheValidationRules.ValidateCreditableCoverageFlag();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateNumberofUncoveredMonths_Empty()
        {
            bool Result = TheValidationRules.ValidateNumberofUncoveredMonths();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateEmployerSubsidyEnrollment_Empty()
        {
            bool Result = TheValidationRules.ValidateEmployerSubsidyEnrollment();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePartDOptOutFlag_Empty()
        {
            bool Result = TheValidationRules.ValidatePartDOptOutFlag();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateSecondaryDrugInsuranceFlag_Empty()
        {
            bool Result = TheValidationRules.ValidateSecondaryDrugInsuranceFlag();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateSecondaryRxId_Empty()
        {
            bool Result = TheValidationRules.ValidateSecondaryRxId();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateSecondRxGroup_Empty()
        {
            bool Result = TheValidationRules.ValidateSecondaryRxGroup();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateEnrollmentSource_Empty()
        {
            bool Result = TheValidationRules.ValidateEnrollmentSource();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateTransactionTrackingId_Empty()
        {
            bool Result = TheValidationRules.ValidateTransactionTrackingId();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePartDRxBIN_Empty()
        {
            bool Result = TheValidationRules.ValidatePartDRxBIN();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePartDRxPCN_Empty()
        {
            bool Result = TheValidationRules.ValidatePartDRxPCN();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePartDRxGroup_Empty()
        {
            bool Result = TheValidationRules.ValidatePartDRxGroup();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePartDRxId_Empty()
        {
            bool Result = TheValidationRules.ValidatePartDRxId();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateSecondaryDrugBIN_Empty()
        {
            bool Result = TheValidationRules.ValidateSecondaryDrugBIN();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateSecondaryDrugPCN_Empty()
        {
            bool Result = TheValidationRules.ValidateSecondaryDrugPCN();
            Assert.AreEqual(true, Result);
        }

    }
}
