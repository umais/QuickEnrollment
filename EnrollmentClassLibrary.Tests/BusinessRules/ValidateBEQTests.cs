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
        public EnrollmentTransaction TheTransaction = new EnrollmentTransaction();
        public String GoodHICN;
        public String GoodBirthDate;
        public String GoodGenderCode;
        public String NullHICN;
        public String NullBirthDate;
        public String NullGenderCode;
        public String BadBEQBadHICN;
        public String BadBirthDate;
        public String BadGenderCode;

        public ValidateBEQ TheValidationRules;

        public ValidateBEQTests()
        {
            TheValidationRules = new ValidateBEQ(TheTransaction);

            GoodHICN = "375689999A";
            GoodBirthDate = "19591114";
            GoodGenderCode = "1";

            NullHICN = null;
            NullBirthDate = null;
            NullGenderCode = null;

            BadBEQBadHICN = "abcdedfghijlkmnop";
            BadBirthDate = "13 May 2013";
            BadGenderCode = "Male";
        }

        private void BuildGoodTransaction()
        {
            TheTransaction.HICN = this.GoodHICN;
            TheTransaction.BirthDate = this.GoodBirthDate;
            TheTransaction.GenderCode = this.GoodGenderCode;
        }

        [TestMethod]
        public void ValidateGoodTransaction()
        {
            BuildGoodTransaction();
            TheValidationRules.transaction = TheTransaction;
            Assert.AreEqual(true, TheValidationRules.ApplyRules());
        }

        [TestMethod]
        public void ValidateBadBEQNullHICN()
        {
            BuildGoodTransaction();
            TheTransaction.HICN = this.NullHICN;

            TheValidationRules.transaction = TheTransaction;
            Assert.AreEqual(false, TheValidationRules.ApplyRules());
        }

        [TestMethod]
        public void ValidateBadBEQBadHICN()
        {
            BuildGoodTransaction();
            TheTransaction.HICN = this.BadBEQBadHICN;

            TheValidationRules.transaction = TheTransaction;
            Assert.AreEqual(false, TheValidationRules.ApplyRules());
        }

        [TestMethod]
        public void ValidateNullBirthDate()
        {
            BuildGoodTransaction();
            TheTransaction.BirthDate = this.NullBirthDate;

            TheValidationRules.transaction = TheTransaction;
            Assert.AreEqual(false, TheValidationRules.ApplyRules());
        }

        [TestMethod]
        public void ValidateBadBirthDate()
        {
            BuildGoodTransaction();
            TheTransaction.BirthDate = this.BadBirthDate;

            TheValidationRules.transaction = TheTransaction;
            Assert.AreEqual(false, TheValidationRules.ApplyRules());
        }

        [TestMethod]
        public void ValidateNullGenderCode()
        {
            BuildGoodTransaction();
            TheTransaction.GenderCode = this.NullGenderCode;

            TheValidationRules.transaction = TheTransaction;
            Assert.AreEqual(true, TheValidationRules.ApplyRules());
        }

        [TestMethod]
        public void ValidateBadGenderCode()
        {
            BuildGoodTransaction();
            TheTransaction.GenderCode = this.BadGenderCode;

            TheValidationRules.transaction = TheTransaction;
            Assert.AreEqual(false, TheValidationRules.ApplyRules());
        }
    }
}
