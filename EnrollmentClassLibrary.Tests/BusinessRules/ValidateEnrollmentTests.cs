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
    public class ValidateEnrollmentTests
    {
        public EnrollmentTransaction TheTransaction = new EnrollmentTransaction();
        public ValidateEnrollment TheValidationRules;

        public ValidateEnrollmentTests()
        {
            TheValidationRules = new ValidateEnrollment(TheTransaction);
        }

        [TestMethod]
        public void ValidateHICN_Null()
        {
            bool Result = TheValidationRules.ValidateHICN();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateSurname_Null()
        {
            bool Result = TheValidationRules.ValidateSurname();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateFirstName_Null()
        {
            bool Result = TheValidationRules.ValidateFirstName();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateMInitial_Null()
        {
            bool Result = TheValidationRules.ValidateMInitial();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateContractNumber_Null()
        {
            bool Result = TheValidationRules.ValidateContractNumber();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateGenderCode_Null()
        {
            bool Result = TheValidationRules.ValidateGenderCode();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateBirthDate_Null()
        {
            bool Result = TheValidationRules.ValidateBirthDate();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateEGHPFlag_Null()
        {
            bool Result = TheValidationRules.ValidateEGHPFlag();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateApplicationDate_Null()
        {
            bool Result = TheValidationRules.ValidateApplicationDate();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateEffectiveDate_Null()
        {
            bool Result = TheValidationRules.ValidateEffectiveDate();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateSegmentId_Null()
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
        public void ValidateESRDOverride_Null()
        {
            bool Result = TheValidationRules.ValidateESRDOverride();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidatePremiumWithholdOption_Null()
        {
            bool Result = TheValidationRules.ValidatePremiumWithholdOption();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePartCPremiumAmount_Null()
        {
            bool Result = TheValidationRules.ValidatePartCPremiumAmount();
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void ValidateCreditCoverageFlag_Null()
        {
            bool Result = TheValidationRules.ValidateCreditableCoverageFlag();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateNumberofUncoveredMonths_Null()
        {
            bool Result = TheValidationRules.ValidateNumberofUncoveredMonths();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateEmployerSubsidyEnrollment_Null()
        {
            bool Result = TheValidationRules.ValidateEmployerSubsidyEnrollment();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidatePartDOptOutFlag_Null()
        {
            bool Result = TheValidationRules.ValidatePartDOptOutFlag();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateSecondaryDrugInsuranceFlag_Null()
        {
            bool Result = TheValidationRules.ValidateSecondaryDrugInsuranceFlag();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateSecondaryRxId_Null()
        {
            bool Result = TheValidationRules.ValidateSecondaryRxId();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateSecondRxGroup_Null()
        {
            bool Result = TheValidationRules.ValidateSecondaryRxGroup();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateEnrollmentSource_Null()
        {
            bool Result = TheValidationRules.ValidateEnrollmentSource();
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void ValidateTransactionTrackingId_Null()
        {
            bool Result = TheValidationRules.ValidateTransactionTrackingId();
            Assert.AreEqual(true, Result);
        }
    }
}
