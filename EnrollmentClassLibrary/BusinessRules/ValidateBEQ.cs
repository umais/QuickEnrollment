using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentClassLibrary.Models;

namespace EnrollmentClassLibrary.BusinessRules
{
    /// <summary>
    /// The <c>ValidateBEQ</c> class contains the business rules needed to verify that a
    /// transaction has the correct data in the appropriate properties for a BEQ request.
    /// </summary>
    public class ValidateBEQ:ValidateBaseClass
    {

        /// <summary>
        /// The constructor accepts a transaction that is cast into a type EnrollmentTransaction.
        /// </summary>
        /// <param name="TheTransaction">The parameter TheTransaction contains an enrollment transaction.</param>
        public ValidateBEQ(EnrollmentTransaction TheTransaction) : base (TheTransaction) { }

        /// <summary>
        /// ValidateHICN edit checks the data for any transaction. The
        /// HICN is required and must not be greater than 12 characters long.
        /// </summary>
        /// <returns>If the HICN is valid, return true, otherwise false.</returns>
        public bool ValidateHICN()
        {
            return Edits.CheckRequired(transaction.HICN)
                 & Edits.MaxLength(transaction.HICN, 12);
        }

        /// <summary>
        /// ValidateBirthDate checks that the incoming date of birth is populated, is a valid
        /// date, and is prior to the current date.
        /// </summary>
        /// <returns>If the BirthDate is valid, return true, otherwise false.</returns>
        public bool ValidateBirthDate()
        {
            return Edits.CheckRequired(transaction.BirthDate)
                 & Edits.CheckIsDate(transaction.BirthDate)
                 & Edits.CheckIsDatePrior(transaction.BirthDate, DateTime.Now);
        }

        /// <summary>
        /// ValidateGenderCode edit checks the data for an enrollment transaction. The
        /// GenderCode is required and must be a 0, 1, or 2
        /// </summary>
        /// <returns>If the GenderCode is valid, return true, otherwise false</returns>
        public bool ValidateGenderCode()
        {
            if (transaction.GenderCode == null) return true; // This field is not required
            return Edits.CheckInList(transaction.GenderCode, new string[] { "0", "1", "2" });
        }

        /// <summary>
        /// The <c>ApplyRules</c> method executes the validations for the transaction.
        /// </summary>
        /// <returns>If the transaction is valid for BEQ, then return true, otherwise false.</returns>
        public override bool ApplyRules()
        {
            return ValidateHICN()
                 & ValidateBirthDate()
                 & ValidateGenderCode();
        }
    }
}
