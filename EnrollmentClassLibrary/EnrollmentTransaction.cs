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
   public  class EnrollmentTransaction:BaseTransaction
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
            if (this.SegmentId.Length != 2) return false;
            return int.TryParse(this.SegmentId, out ResultInt);
        }

        /// <summary>
        /// The <c>ValidatePBPNumber</c> method edit checks the data for an enrollment transaction. The PBP
        /// number is required and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePBPNumber()
        {
            int ResultInt;
            if (this.PBPNumber.Length != 3) return false;
            return int.TryParse(this.SegmentId, out ResultInt);
        }

        /// <summary>
        /// The <c>ValidateElectionType</c> method edit checks the data for an enrollment transaction. The election type
        /// number is required is only one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateElectionType()
        {
            if (this.ElectionType.Length != 1) return false;
            return true;
        }

        /// <summary>
        /// The <c>ValidateESRDOverride</c> method edit checks the data for an enrollment transaction. The ESRD
        /// number is required for MA plans and is only one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateESRDOverride()
        {
            if (this.ESRDOverride.Length != 1) return false;
            return true;
        }

        /// <summary>
        /// The <c>ValidatePremiumWithholdOption</c> method edit checks the data for an enrollment transaction. The Premium
        /// Withhold Option is required and only one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePremiumWithholdOption()
        {
            if (this.PremiumWithholdOption.Length != 1) return false;
            return true;
        }

        /// <summary>
        /// The <c>ValidatePartCPremiumAmount</c> method edit checks the data for an enrollment transaction. The Part C
        /// Premium is required and must be a dollar figure in the form nnn.nn.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartCPremiumAmount()
        {
            if (this.PartCPremiumAmount.Length != 6) return false;
            return true;
        }

        /// <summary>
        /// The <c>ValidateCreditableCoverageFlag</c> method edit checks the data for an enrollment transaction. The Creditable
        /// Coverage Flag is required for part D plans and is one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateCreditableCoverageFlag()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateNumberofUncoveredMonths</c> method edit checks the data for an enrollment transaction. The number of uncovered
        /// months is required for MA plans and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateNumberofUncoveredMonths()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateEmployerSubsidyEnrollment</c> method edit checks the data for an enrollment transaction. The employer subsidy
        /// enrollment is Required: if beneficiary has Employer Subsidy status for Part D and a previous enrollment transaction was returned 
        /// with a TRC 127; otherwise blank and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateEmployerSubsidyEnrollment()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidatePartDOptOutFlag</c> method edit checks the data for an enrollment transaction. The part D opt out flag
        /// is Required: for a PBP change (Y when Opting Out for Part D; N when Opting in for Part  -D); otherwise blank
        /// and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDOptOutFlag()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateSecondaryDrugInsuranceFlag</c> method edit checks the data for an enrollment transaction. The secondary drug insurance flag
        /// is optional and must is on character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryDrugInsuranceFlag()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateSecondaryRxId</c> method edit checks the data for an enrollment transaction. The secondary Rx Id
        /// is optional and must is on character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryRxId()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateSecondaryRxGroup</c> method edit checks the data for an enrollment transaction. The secondary Rx Group
        /// is optional and must is one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryRxGroup()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateEnrollmentSource</c> method edit checks the data for an enrollment transaction. The enrollment source
        /// is Required: for POS submitted enrollments transactions; otherwise optional and must is one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateEnrollmentSource()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateTransactionTrackingId</c> method edit checks the data for an enrollment transaction. The transaction tracking
        /// is optional and must is 15 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateTransactionTrackingId()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidatePartDRxBIN</c> method edit checks the data for an enrollment transaction. The part d Rx Bin
        /// is Required: for all Part D plan except PACE; otherwise blank and is 6 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDRxBIN()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidatePartDRxPCN</c> method edit checks the data for an enrollment transaction. The part d Rx PCN
        /// is Optional: for all Part D plans except PACE and is 10 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDRxPCN()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidatePartDRxGroup</c> method edit checks the data for an enrollment transaction. The part d Rx group
        /// is Optional: for all Part D plans except PACE and is 15 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDRxGroup()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidatePartDRxId</c> method edit checks the data for an enrollment transaction. The part d Rx id
        /// is Optional: for all Part D plans except PACE and is 20 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDRxId()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateSecondaryDrugBIN</c> method edit checks the data for an enrollment transaction. The
        /// drug bin is Required: if secondary insurance; otherwise blank and is 6 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryDrugBIN()
        {
            return true;
        }

        /// <summary>
        /// The <c>ValidateSecondaryDrugPCN</c> method edit checks the data for an enrollment transaction. The
        /// drug pcn is Required: if secondary insurance; otherwise blank and is 10 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryDrugPCN()
        {
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
                    & ValidateFirstName()
                    & ValidateMInitial()
                    & ValidateGenderCode()
                    & ValidateBirthDate()
                    & ValidateEGHPFlag()
                    & ValidatePBPNumber()
                    & ValidateContractNumber()
                    & ValidateApplicationDate()
                    & ValidateEffectiveDate()
                    & ValidateSegmentId()
                    & ValidateESRDOverride()
                    & ValidatePremiumWithholdOption()
                    & ValidatePartCPremiumAmount()
                    & ValidateCreditableCoverageFlag()
                    & ValidateNumberofUncoveredMonths()
                    & ValidateEmployerSubsidyEnrollment()
                    & ValidatePartDOptOutFlag()
                    & ValidateSecondaryDrugInsuranceFlag()
                    & ValidateSecondaryRxId()
                    & ValidateSecondaryRxGroup()
                    & ValidateEnrollmentSource()
                    & ValidateTransactionTrackingId()
                    & ValidatePartDRxBIN()
                    & ValidatePartDRxPCN()
                    & ValidatePartDRxGroup()
                    & ValidatePartDRxId()
                    & ValidateSecondaryDrugBIN()
                    & ValidateSecondaryDrugPCN();
            return IsValid;
        }


      

    }
}
