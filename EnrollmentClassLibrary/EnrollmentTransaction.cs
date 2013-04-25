using System;
using System.Globalization;
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
        /// ValidateGenderCode edit checks the data for an enrollment transaction. The
        /// GenderCode is required and must be a 0, 1, or 2
        /// </summary>
        /// <returns>If the GenderCode is valid, return true, otherwise false</returns>
        public bool ValidateGenderCode()
        {
            bool IsValid = true;
            switch (this.GenderCode)
            {
                case "0":
                    IsValid = true;
                    break;
                case "1":
                    IsValid = true;
                    break;
                case "2":
                    IsValid =  true;
                    break;
                default:
                    IsValid =  false;
                    break;
            }
            return IsValid;
        }

        /// <summary>
        /// The <c>ValidateBirthDate</c> edit checks the data for an enrollment transaction. The
        /// BirthDate is required and must be a valid date.
        /// </summary>
        /// <returns>If the birthdate is a string in YYYYMMDD format, then true, otherwise false</returns>
        public bool ValidateBirthDate()
        {
            CultureInfo enUS = new CultureInfo("en-US"); 
            DateTime ResultDate;
            return DateTime.TryParseExact(this.BirthDate, "yyyyMMdd", enUS, DateTimeStyles.None, out ResultDate);
        }

        /// <summary>
        /// The <c>ValidateEGHPFlag</c> edit checks the data for an enrollment transaction. The EGHP is required
        /// for a plan submitting an EGHP enrollment. The value is required and must be "0" or "1".
        /// </summary>
        /// <returns>When the flag </returns>
        public bool ValidateEGHPFlag()
        {
            bool IsValid = true;
            switch (this.EGHPFlag)
            {
                case "0":
                    IsValid = true;
                    break;
                case "1":
                    IsValid = true;
                    break;
                default:
                    IsValid = false;
                    break;
            }
            return IsValid;
        }

        /// <summary>
        /// The method <c>ValidateApplicationDate</c> edit checks the application date for the enrollment transaction.
        /// The date is required and in a yyyymmdd format.
        /// </summary>
        /// <returns>If the application date is valid then true otherwise false</returns>
        public bool ValidateApplicationDate()
        {
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime ResultDate;
            return DateTime.TryParseExact(this.ApplicationDate, "yyyyMMdd", enUS, DateTimeStyles.None, out ResultDate);
        }

        /// <summary>
        /// The method <c>ValidateApplicationDate</c> edit checks the application date for the enrollment transaction.
        /// The date is required and in a yyyymmdd format.
        /// </summary>
        /// <returns>If the effective date is valid then true otherwise false</returns>
        public bool ValidateEffectiveDate()
        {
            CultureInfo enUS = new CultureInfo("en-US");
            DateTime ResultDate;
            return DateTime.TryParseExact(this.EffectiveDate, "yyyyMMdd", enUS, DateTimeStyles.None, out ResultDate);
        }

        /// <summary>
        /// The <c>ValidateSegmentId</c> method edit checks the data for an enrollment transaction. The
        /// Segment Id is required and must be a two digit integer with leading zeros.
        /// </summary>
        /// <returns>If the Segment Id is valid, then true otherwise false</returns>
        public bool ValidateSegmentId()
        {
            int ResultInt;
            if (this.SegmentId.Length < 2) return false;
            if (this.SegmentId.Length > 2) return false;
            return int.TryParse(this.SegmentId, out ResultInt);
        }

        /// <summary>
        /// The <c>ValidatePBPNumber</c> method edit checks the data for an enrollment transaction. The PBP
        /// number is required and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns></returns>
        public bool ValidatePBPNumber()
        {
            int ResultInt;
            if (this.PBPNumber.Length < 3) return false;
            if (this.PBPNumber.Length > 3) return false;
            return int.TryParse(this.SegmentId, out ResultInt);
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
                    & ValidateFirstName()
                    & ValidateMInitial()
                    & ValidateGenderCode()
                    & ValidateBirthDate()
                    & ValidateEGHPFlag()
                    & ValidatePBPNumber()
                    & ValidateContractNumber()
                    & ValidateApplicationDate()
                    & ValidateEffectiveDate()
                    & ValidateSegmentId();
            return IsValid;
        }

    }
}
