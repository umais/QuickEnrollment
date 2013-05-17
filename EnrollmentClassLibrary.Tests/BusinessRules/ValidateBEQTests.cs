using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnrollmentClassLibrary.BusinessRules;
using EnrollmentClassLibrary.Models;


namespace EnrollmentClassLibrary.Tests.BusinessRules
{
    /// <summary>
    /// The <c>ValidateBEQTests</c> class is a unit test class for ValidateBEQ
    /// if a field is required, then the result should be false. If the field is optional, then 
    /// the result should be true.
    /// </summary>
    [TestClass]
    public class ValidateBEQTests
    {
        public EnrollmentTransaction TheTransaction1 = new EnrollmentTransaction();
        public EnrollmentTransaction TheTransaction2 = new EnrollmentTransaction();
        public ValidateEnrollment TheValidationRules;

        public ValidateBEQTests()
        {
            TheValidationRules = new ValidateEnrollment(TheTransaction1);

            TheTransaction1.HICN = "375689999A";
            TheTransaction2.HICN = null;
        }

        [TestMethod]
        public void ValidateGoodBEQ()
        {
            TheValidationRules.transaction = TheTransaction1;
            Assert.AreEqual(true, TheValidationRules.ApplyRules());
        }

        [TestMethod]
        public void ValidateBadBEQ()
        {
            TheValidationRules.transaction = TheTransaction2;
            Assert.AreEqual(false, TheValidationRules.ApplyRules());
        }
    }
}
