using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnrollmentClassLibrary.BusinessRules;

namespace EnrollmentClassLibrary.Tests.BusinessRules
{
    [TestClass]
    public class BasicEditChecksTests
    {
        private BasicEditChecks Edits = new BasicEditChecks();
        private string[] TestArray = new string[] { "0", "1", "3", "22" };

        [TestMethod]
        public void CheckInList_Valid()
        {
            bool Result = Edits.CheckInList("0", TestArray);
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void CheckInList_NotFound()
        {
            bool Result = Edits.CheckInList("2", TestArray);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckInList_NullValue()
        {
            bool Result = Edits.CheckInList(null, TestArray);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckIsDate_Valid()
        {
            bool Result = Edits.CheckIsDate("19591114");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void CheckIsDate_BadDate()
        {
            bool Result = Edits.CheckIsDate("123ABC");
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckIsDate_BadFormat()
        {
            bool Result = Edits.CheckIsDate("11/14/1959");
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckIsInt_Valid()
        {
            bool Result = Edits.CheckIsInt("12345667");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void CheckIsInt_Alpha()
        {
            bool Result = Edits.CheckIsInt("ABC");
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckIsInt_Decimal()
        {
            bool Result = Edits.CheckIsInt("1234.56");
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckLength_Valid()
        {
            bool Result = Edits.CheckLength("ABC", 3);
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void CheckLength_Short()
        {
            bool Result = Edits.CheckLength("ABC", 5);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckLength_Long()
        {
            bool Result = Edits.CheckLength("ABC", 1);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckLength_Empty()
        {
            bool Result = Edits.CheckLength(null, 64);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckRequired_Valid()
        {
            bool Result = Edits.CheckRequired("ABC");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void CheckRequired_Null()
        {
            bool Result = Edits.CheckRequired(null);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckRequired_Empty()
        {
            bool Result = Edits.CheckRequired("");
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void CheckRequired_Space()
        {
            bool Result = Edits.CheckRequired(" ");
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void MaxLength_Valid()
        {
            bool Result = Edits.MaxLength("ABC", 10);
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MaxLength_Equal()
        {
            bool Result = Edits.MaxLength("ABC", 3);
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MaxLength_TooLong()
        {
            bool Result = Edits.MaxLength("ABC", 2);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void MaxLength_Null()
        {
            bool Result = Edits.MaxLength(null, 0);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void MinLength_Valid()
        {
            bool Result = Edits.MinLength("ABC", 2);
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MinLength_Equal()
        {
            bool Result = Edits.MinLength("ABC", 3);
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MinLength_TooShort()
        {
            bool Result = Edits.MinLength("ABC", 5);
            Assert.AreEqual(false, Result);
        }

        [TestMethod]
        public void MinLength_NullOK()
        {
            bool Result = Edits.MinLength(null, 0);
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MinLength_NullShort()
        {
            bool Result = Edits.MinLength(null, 1);
            Assert.AreEqual(false, Result);
        }
    }
}
