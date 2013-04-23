using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>EnrollmentTransaction</c> is the object for enrollment transactions.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    class EnrollmentTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "61" is used for all enrollment transactions
        /// </summary>
        public const string TransactionCode = "61";

        /// <summary>
        /// ValidateHICN edit checks the data for an enrollment transaction. The
        /// HICN is required and must not be greater than 12 characters long.
        /// </summary>
        /// <returns>If the HICN is valid, return true, otherwise false.</returns>
        public bool ValidateHICN()
        {
            if (this.HICN.Length < 1)  return false;
            if (this.HICN.Length > 12) return false;
            return true;
        }

        /// <summary>
        /// ValidateSurname edit checks the data for an enrollment transaction. The
        /// Surname is required and must not be greater than 12 characters long.
        /// </summary>
        /// <returns>If the Surname is valid, return true, otherwise false.</returns>
        public bool ValidateSurname()
        {
            if (this.Surname.Length < 1) return false;
            if (this.Surname.Length > 12) return false;
            return true;
        }

        /// <summary>
        /// ValidateFirstName edit checks the data for an enrollment transaction. The
        /// FirstName is required and must not be greater than 7 characters long.
        /// </summary>
        /// <returns>If the FirstName is valid, return true, otherwise false.</returns>
        public bool ValidateFirstName()
        {
            if (this.FirstName.Length < 1) return false;
            if (this.FirstName.Length > 7) return false;
            return true;
        }

        /// <summary>
        /// The <c>Validate</c> method checks all the properties in the transaction.
        /// </summary>
        /// <returns>If all the elements are valid, the method returns true, otherwise
        /// if returns false.</returns>
        public new bool Validate()
        {
            bool IsValid = true;

            // Use the AND operator to assure the method only returns true was all values are valid.
            IsValid = IsValid 
                    & ValidateHICN() 
                    & ValidateSurname() 
                    & ValidateFirstName();
            return IsValid;
        }

    }
}
