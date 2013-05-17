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
    class ValidateBEQ:ValidateBaseClass
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
        /// The <c>ApplyRules</c> method executes the validations for the transaction.
        /// </summary>
        /// <returns>If the transaction is valid for BEQ, then return true, otherwise false.</returns>
        public override bool ApplyRules()
        {
            return ValidateHICN();
        }
    }
}
