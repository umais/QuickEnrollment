using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EnrollmentClassLibrary;
namespace QuickEnrollment.Tests
{
    [TestClass]
    public class UnitTest1
    {

        public Member getMemberObject()
        {
            return new Member { FirstName = "Umais", LastName = "Siddiqui", DateOfBirth = "06NotvAlid/1980", Gender = "M" };
        }
        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Not_Valid_DateOfBirth()
        {
            Member m = getMemberObject();
             m.getAge();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Not_Valid_Future_DateOfBirth()
        {
            Member member = getMemberObject();
            member.DateOfBirth = DateTime.Now.AddDays(10).ToShortDateString();
            member.getAge();
            
        }

        [TestMethod]
        public void Valid_Age()
        {
            Member m = getMemberObject();
            m.DateOfBirth = "06/15/1980";
            m.getAge();
            int age = m.Age;

            Assert.IsTrue(age > 0, "Not a valid age");
        }
    }
}
