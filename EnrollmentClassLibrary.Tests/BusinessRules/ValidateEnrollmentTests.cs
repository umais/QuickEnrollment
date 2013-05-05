using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnrollmentClassLibrary.BusinessRules;
using EnrollmentClassLibrary.Models;

namespace EnrollmentClassLibrary.Tests.BusinessRules
{
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
    }
}
