using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentClassLibrary.Models;


namespace EnrollmentClassLibrary.BusinessRules
{
    /// <summary>
    /// The <c>ValidateEnrollment</c> class edit the elements of the enrollment transaction to assure they
    /// can be accepted by CMS.
    /// </summary>
    public class ValidateEnrollment:ITransactionRules
    {
        /// <summary>
        /// The property transaction contains the model for the EnrollmentTransaction.
        /// </summary>
        public EnrollmentTransaction transaction { get; set; }
        private BasicEditChecks Edits = new BasicEditChecks();

        /// <summary>
        /// The constructor accepts a transaction that is cast into a type EnrollmentTransaction.
        /// </summary>
        /// <param name="TheTransaction">The parameter TheTransaction contains an enrollment transaction.</param>
        public ValidateEnrollment(EnrollmentTransaction TheTransaction)
        {
            transaction = TheTransaction;
        }

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
        /// ValidateSurname edit checks the data for any transaction. The
        /// Surname is required and must not be greater than 12 characters long.
        /// </summary>
        /// <returns>If the Surname is valid, return true, otherwise false.</returns>
        public bool ValidateSurname()
        {
            return Edits.CheckRequired(transaction.Surname)
                 & Edits.MaxLength(transaction.Surname, 12);
        }

        /// <summary>
        /// ValidateFirstName edit checks the data for any transaction. The
        /// FirstName is required and must not be greater than 7 characters long.
        /// </summary>
        /// <returns>If the FirstName is valid, return true, otherwise false.</returns>
        public bool ValidateFirstName()
        {
            return Edits.CheckRequired(transaction.FirstName)
                 & Edits.MaxLength(transaction.FirstName, 7);
        }

        /// <summary>
        /// ValidateMInitial edit checks the data for any transaction. The
        /// MInitial is optional and must not be greater than 1 character long.
        /// </summary>
        /// <returns>If the initial is a single character, return true otherwise return false</returns>
        public bool ValidateMInitial()
        {
            return Edits.MaxLength(transaction.MInitial, 1);
        }

        /// <summary>
        /// ValidateContractNumber edit checks the data for all transactions. The contract number
        /// is required, is five characters long. The first position is a letter and the remaining are digits.
        /// </summary>
        /// <returns>If the contract number is valid then true, otherwise false</returns>
        public bool ValidateContractNumber()
        {
            return Edits.CheckRequired(transaction.ContractNumber)
                 & Edits.MaxLength(transaction.ContractNumber, 5);
        }

        /// <summary>
        /// ValidateGenderCode edit checks the data for an enrollment transaction. The
        /// GenderCode is required and must be a 0, 1, or 2
        /// </summary>
        /// <returns>If the GenderCode is valid, return true, otherwise false</returns>
        public bool ValidateGenderCode()
        {
            return Edits.CheckRequired(transaction.GenderCode)
                 & Edits.CheckInList(transaction.GenderCode, new string[] {"0", "1", "2"});
        }

        /// <summary>
        /// The <c>ValidateBirthDate</c> edit checks the data for an enrollment transaction. The
        /// BirthDate is required and must be a valid date.
        /// </summary>
        /// <returns>If the birthdate is a string in YYYYMMDD format, then true, otherwise false</returns>
        public bool ValidateBirthDate()
        {
            return Edits.CheckRequired(transaction.BirthDate)
                 & Edits.CheckIsDate(transaction.BirthDate);
        }

        /// <summary>
        /// The <c>ValidateEGHPFlag</c> edit checks the data for an enrollment transaction. The EGHP is required
        /// for a plan submitting an EGHP enrollment. The value is required and must be "0" or "1".
        /// </summary>
        /// <returns>When the flag </returns>
        public bool ValidateEGHPFlag()
        {
            if (transaction.EGHPFlag == null) return true; // This field is not required
            return Edits.CheckInList(transaction.EGHPFlag, new string[] { "0", "1" });
        }

        /// <summary>
        /// The method <c>ValidateApplicationDate</c> edit checks the application date for the enrollment transaction.
        /// The date is required and in a yyyymmdd format.
        /// </summary>
        /// <returns>If the application date is valid then true otherwise false</returns>
        public bool ValidateApplicationDate()
        {
            return Edits.CheckRequired(transaction.ApplicationDate)
                 & Edits.CheckIsDate(transaction.ApplicationDate);
        }

        /// <summary>
        /// The method <c>ValidateApplicationDate</c> edit checks the application date for the enrollment transaction.
        /// The date is required and in a yyyymmdd format.
        /// </summary>
        /// <returns>If the effective date is valid then true otherwise false</returns>
        public bool ValidateEffectiveDate()
        {
            return Edits.CheckIsDate(transaction.EffectiveDate);
        }

        /// <summary>
        /// The <c>ValidateSegmentId</c> method edit checks the data for an enrollment transaction. The
        /// Segment Id is required and must be a two digit integer with leading zeros.
        /// </summary>
        /// <returns>If the Segment Id is valid, then true otherwise false</returns>
        public bool ValidateSegmentId()
        {
            return Edits.CheckRequired(transaction.SegmentId)
                 & Edits.CheckLength(transaction.SegmentId, 2)
                 & Edits.CheckIsInt(transaction.SegmentId);
        }

        /// <summary>
        /// The <c>ValidatePBPNumber</c> method edit checks the data for an enrollment transaction. The PBP
        /// number is required and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePBPNumber()
        {
            return Edits.CheckRequired(transaction.PBPNumber)
                 & Edits.CheckLength(transaction.PBPNumber, 2)
                 & Edits.CheckIsInt(transaction.PBPNumber);
        }

        /// <summary>
        /// The <c>ValidateElectionType</c> method edit checks the data for an enrollment transaction. The election type
        /// number is required is only one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateElectionType()
        {
            return Edits.CheckLength(transaction.ElectionType, 1);
        }

        /// <summary>
        /// The <c>ValidateESRDOverride</c> method edit checks the data for an enrollment transaction. The ESRD
        /// number is required for MA plans and is only one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateESRDOverride()
        {
            return Edits.CheckLength(transaction.ElectionType, 1);
        }

        /// <summary>
        /// The <c>ValidatePremiumWithholdOption</c> method edit checks the data for an enrollment transaction. The Premium
        /// Withhold Option is required and only one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePremiumWithholdOption()
        {
            return Edits.CheckLength(transaction.PremiumWithholdOption, 1);
        }

        /// <summary>
        /// The <c>ValidatePartCPremiumAmount</c> method edit checks the data for an enrollment transaction. The Part C
        /// Premium is required and must be a dollar figure in the form nnn.nn.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartCPremiumAmount()
        {
            return Edits.CheckLength(transaction.PartCPremiumAmount, 6);
        }

        /// <summary>
        /// The <c>ValidateCreditableCoverageFlag</c> method edit checks the data for an enrollment transaction. The Creditable
        /// Coverage Flag is required for part D plans and is one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateCreditableCoverageFlag()
        {
            return Edits.MaxLength(transaction.CreditableCoverageFlag, 1);
        }

        /// <summary>
        /// The <c>ValidateNumberofUncoveredMonths</c> method edit checks the data for an enrollment transaction. The number of uncovered
        /// months is required for MA plans and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateNumberofUncoveredMonths()
        {
            if (transaction.NumberofUncoveredMonths == null) return true;
            return Edits.CheckLength(transaction.NumberofUncoveredMonths, 3)
                 & Edits.CheckIsInt(transaction.NumberofUncoveredMonths);
        }

        /// <summary>
        /// The <c>ValidateEmployerSubsidyEnrollment</c> method edit checks the data for an enrollment transaction. The employer subsidy
        /// enrollment is Required: if beneficiary has Employer Subsidy status for Part D and a previous enrollment transaction was returned 
        /// with a TRC 127; otherwise blank and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateEmployerSubsidyEnrollment()
        {
            return Edits.MaxLength(transaction.EmployerSubsidyEnrollment, 1);
        }

        /// <summary>
        /// The <c>ValidatePartDOptOutFlag</c> method edit checks the data for an enrollment transaction. The part D opt out flag
        /// is Required: for a PBP change (Y when Opting Out for Part D; N when Opting in for Part  -D); otherwise blank
        /// and must be a three digit integer with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDOptOutFlag()
        {
            return Edits.MaxLength(transaction.PartDOptOutFlag, 1);
        }

        /// <summary>
        /// The <c>ValidateSecondaryDrugInsuranceFlag</c> method edit checks the data for an enrollment transaction. The secondary drug insurance flag
        /// is optional and must is on character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryDrugInsuranceFlag()
        {
            return Edits.CheckLength(transaction.SecondaryDrugInsuranceFlag, 1);
        }

        /// <summary>
        /// The <c>ValidateSecondaryRxId</c> method edit checks the data for an enrollment transaction. The secondary Rx Id
        /// is optional and must is on character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryRxId()
        {
            return Edits.CheckLength(transaction.SecondaryRxId, 20);
        }

        /// <summary>
        /// The <c>ValidateSecondaryRxGroup</c> method edit checks the data for an enrollment transaction. The secondary Rx Group
        /// is optional and must is one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryRxGroup()
        {
            return Edits.CheckLength(transaction.SecondaryRxGroup, 15);
        }

        /// <summary>
        /// The <c>ValidateEnrollmentSource</c> method edit checks the data for an enrollment transaction. The enrollment source
        /// is Required: for POS submitted enrollments transactions; otherwise optional and must is one character.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateEnrollmentSource()
        {
            return Edits.CheckLength(transaction.EnrollmentSource, 1);
        }

        /// <summary>
        /// The <c>ValidateTransactionTrackingId</c> method edit checks the data for an enrollment transaction. The transaction tracking
        /// is optional and must is 15 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateTransactionTrackingId()
        {
            return Edits.CheckLength(transaction.TransactionTrackingId, 15)
                 & Edits.CheckIsInt(transaction.TransactionTrackingId);
        }

        /// <summary>
        /// The <c>ValidatePartDRxBIN</c> method edit checks the data for an enrollment transaction. The part d Rx Bin
        /// is Required: for all Part D plan except PACE; otherwise blank and is 6 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDRxBIN()
        {
            return Edits.CheckLength(transaction.PartDRxBIN, 6);
        }

        /// <summary>
        /// The <c>ValidatePartDRxPCN</c> method edit checks the data for an enrollment transaction. The part d Rx PCN
        /// is Optional: for all Part D plans except PACE and is 10 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDRxPCN()
        {
            return Edits.CheckLength(transaction.PartDRxPCN, 10);
        }

        /// <summary>
        /// The <c>ValidatePartDRxGroup</c> method edit checks the data for an enrollment transaction. The part d Rx group
        /// is Optional: for all Part D plans except PACE and is 15 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDRxGroup()
        {
            return Edits.CheckLength(transaction.PartDRxGroup, 15);
        }

        /// <summary>
        /// The <c>ValidatePartDRxId</c> method edit checks the data for an enrollment transaction. The part d Rx id
        /// is Optional: for all Part D plans except PACE and is 20 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidatePartDRxId()
        {
            return Edits.CheckLength(transaction.PartDRxId, 20);
        }

        /// <summary>
        /// The <c>ValidateSecondaryDrugBIN</c> method edit checks the data for an enrollment transaction. The
        /// drug bin is Required: if secondary insurance; otherwise blank and is 6 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryDrugBIN()
        {
            return Edits.CheckLength(transaction.SecondaryDrugBIN, 6);
        }

        /// <summary>
        /// The <c>ValidateSecondaryDrugPCN</c> method edit checks the data for an enrollment transaction. The
        /// drug pcn is Required: if secondary insurance; otherwise blank and is 10 numeric characters with leading zeros.
        /// </summary>
        /// <returns>If the value is valid for this property and transaction, then return true, otherwise return false</returns>
        public bool ValidateSecondaryDrugPCN()
        {
            return Edits.CheckLength(transaction.SecondaryDrugPCN, 10);
        }

        /// <summary>
        /// The <c>ApplyRules</c> method executes the validations for the enrollment transaction.
        /// </summary>
        /// <returns>If the transaction is correct, then return true, otherwise false.</returns>
        public bool ApplyRules()
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
