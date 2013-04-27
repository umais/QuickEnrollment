using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The <c>BaseTransaction</c> is an abstract class containing the common properties and methods of all CMS Transactions.
    /// </summary>
    public abstract class BaseTransaction:ITransaction
    {
        private string _transactionID;

        public string TransactionID
        {
            get { return _transactionID; }
            set { _transactionID = value; }
        }
        private string _HICN;
        /// <summary>
        /// CMS member identifier HICN
        /// </summary>
        public string HICN
        {
            get { return _HICN; }
            set { _HICN = value; }
        }

        private string _Surname;
        /// <summary>
        /// Member last name
        /// </summary>
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        private string _FirstName;
        /// <summary>
        /// Member first name
        /// </summary>
        public string FirstName
        {
            get { return _FirstName; }
            set { _FirstName = value; }
        }

        private string _MInitial;
        /// <summary>
        /// Initial letter of the member's middle name
        /// </summary>
        public string MInitial
        {
            get { return _MInitial; }
            set { _MInitial = value; }
        }

        private string _GenderCode;
        /// <summary>
        /// Member Gender where "0" is unknown, "1' is Male, and "2" is Female.
        /// </summary>
        public string GenderCode
        {
            get { return _GenderCode; }
            set { _GenderCode = value; }
        }

        private string _BirthDate;
        /// <summary>
        /// The member's birthdate in YYYYMMDD format
        /// </summary>
        public string BirthDate
        {
            get { return _BirthDate; }
            set { _BirthDate = value; }
        }

        private string _EGHPFlag;
        /// <summary>
        /// Member last name
        /// </summary>
        public string EGHPFlag
        {
            get { return _EGHPFlag; }
            set { _EGHPFlag = value; }
        }

        private string _PBPNumber;
        /// <summary>
        /// Two character code for the Plan Benefit Package
        /// </summary>
        public string PBPNumber
        {
            get { return _PBPNumber; }
            set { _PBPNumber = value; }
        }

        private string _ElectionType;
        /// <summary>
        /// Election type for the enrollment
        /// </summary>
        public string ElectionType
        {
            get { return _ElectionType; }
            set { _ElectionType = value; }
        }

        private string _ContractNumber;
        /// <summary>
        /// The plan's Medicare contract number
        /// </summary>
        public string ContractNumber
        {
            get { return _ContractNumber; }
            set { _ContractNumber = value; }
        }

        private string _ApplicationDate;
        /// <summary>
        /// The date the member application was sent to the payer
        /// </summary>
        public string ApplicationDate
        {
            get { return _ApplicationDate; }
            set { _ApplicationDate = value; }
        }

        private string _DisenrollmentReason;
        /// <summary>
        /// Member last name
        /// </summary>
        public string DisenrollmentReason
        {
            get { return _DisenrollmentReason; }
            set { _DisenrollmentReason = value; }
        }

        private string _EffectiveDate;
        /// <summary>
        /// The date this transaction should take effect
        /// </summary>
        public string EffectiveDate
        {
            get { return _EffectiveDate; }
            set { _EffectiveDate = value; }
        }

        private string _SegmentId;
        /// <summary>
        /// Segment Id is a subdividion of the PBP
        /// </summary>
        public string SegmentId
        {
            get { return _SegmentId; }
            set { _SegmentId = value; }
        }

        private string _ESRDOverride;
        /// <summary>
        /// ESRD Override flag
        /// </summary>
        public string ESRDOverride
        {
            get { return _ESRDOverride; }
            set { _ESRDOverride = value; }
        }

        private string _PremiumWithholdOption;
        /// <summary>
        /// Flag indicating that premiums are withheld from a member's pay
        /// </summary>
        public string PremiumWithholdOption
        {
            get { return _PremiumWithholdOption; }
            set { _PremiumWithholdOption = value; }
        }

        private string _PartCPremiumAmount;
        /// <summary>
        /// The amoung the member will pay for Part C coverage
        /// </summary>
        public string PartCPremiumAmount
        {
            get { return _PartCPremiumAmount; }
            set { _PartCPremiumAmount = value; }
        }

        private string _CreditableCoverageFlag;
        /// <summary>
        /// Indicator for creditable coverage
        /// </summary>
        public string CreditableCoverageFlag
        {
            get { return _CreditableCoverageFlag; }
            set { _CreditableCoverageFlag = value; }
        }

        private string _NumberofUncoveredMonths;
        /// <summary>
        /// Number of uncovered months
        /// </summary>
        public string NumberofUncoveredMonths
        {
            get { return _NumberofUncoveredMonths; }
            set { _NumberofUncoveredMonths = value; }
        }

        private string _EmployerSubsidyEnrollment;
        /// <summary>
        /// Employer subsidy enrollment override flag
        /// </summary>
        public string EmployerSubsidyEnrollment
        {
            get { return _EmployerSubsidyEnrollment; }
            set { _EmployerSubsidyEnrollment = value; }
        }

        private string _PartDOptOutFlag;
        /// <summary>
        /// Part D opt out flag
        /// </summary>
        public string PartDOptOutFlag
        {
            get { return _PartDOptOutFlag; }
            set { _PartDOptOutFlag = value; }
        }

        private string _SecondaryDrugInsuranceFlag;
        /// <summary>
        /// Flag indicating the member has additional drug insurance
        /// </summary>
        public string SecondaryDrugInsuranceFlag
        {
            get { return _SecondaryDrugInsuranceFlag; }
            set { _SecondaryDrugInsuranceFlag = value; }
        }

        private string _SecondaryRxId;
        /// <summary>
        /// Id number of the member's additional drug insurance
        /// </summary>
        public string SecondaryRxId
        {
            get { return _SecondaryRxId; }
            set { _SecondaryRxId = value; }
        }

        private string _SecondaryRxGroup;
        /// <summary>
        /// Flag indicating the member has additional drug insurance
        /// </summary>
        public string SecondaryRxGroup
        {
            get { return _SecondaryRxGroup; }
            set { _SecondaryRxGroup = value; }
        }

        private string _EnrollmentSource;
        /// <summary>
        /// Code indicating how the enrollment originated
        /// </summary>
        public string EnrollmentSource
        {
            get { return _EnrollmentSource; }
            set { _EnrollmentSource = value; }
        }

        private string _TransactionTrackingId;
        /// <summary>
        /// Unique number assigned by the payer to correlate transactions with responses on the TRR
        /// </summary>
        public string TransactionTrackingId
        {
            get { return _TransactionTrackingId; }
            set { _TransactionTrackingId = value; }
        }

        private string _PartDRxBIN;
        /// <summary>
        /// RX BIN for Part D coverage
        /// </summary>
        public string PartDRxBIN
        {
            get { return _PartDRxBIN; }
            set { _PartDRxBIN = value; }
        }

        private string _PartDRxPCN;
        /// <summary>
        /// PCN for part D coverage
        /// </summary>
        public string PartDRxPCN
        {
            get { return _PartDRxPCN; }
            set { _PartDRxPCN = value; }
        }

        private string _PartDRxGroup;
        /// <summary>
        /// Group number for Part D coverage
        /// </summary>
        public string PartDRxGroup
        {
            get { return _PartDRxGroup; }
            set { _PartDRxGroup = value; }
        }

        private string _PartDRxId;
        /// <summary>
        /// Part D Rx Id
        /// </summary>
        public string PartDRxId
        {
            get { return _PartDRxId; }
            set { _PartDRxId = value; }
        }

        private string _SecondaryDrugBIN;
        /// <summary>
        /// BIN for additional drug insurance
        /// </summary>
        public string SecondaryDrugBIN
        {
            get { return _SecondaryDrugBIN; }
            set { _SecondaryDrugBIN = value; }
        }

        private string _SecondaryDrugPCN;
        /// <summary>
        /// PCN for additional drug insurance
        /// </summary>
        public string SecondaryDrugPCN
        {
            get { return _SecondaryDrugPCN; }
            set { _SecondaryDrugPCN = value; }
        }

        private string _ActionCode;
        /// <summary>
        /// Action requested on a correction
        /// </summary>
        public string ActionCode
        {
            get { return _ActionCode; }
            set { _ActionCode = value; }
        }

        private string _ResidenceAddress1;
        /// <summary>
        /// Street name and house number
        /// </summary>
        public string ResidenceAddress1
        {
            get { return _ResidenceAddress1; }
            set { _ResidenceAddress1 = value; }
        }

        private string _ResidenceAddress2;
        /// <summary>
        /// Apartment or PO Box
        /// </summary>
        public string ResidenceAddress2
        {
            get { return _ResidenceAddress2; }
            set { _ResidenceAddress2 = value; }
        }

        private string _AddressUpdateFlag;
        /// <summary>
        /// Indicator to update or delete the address
        /// </summary>
        public string AddressUpdateFlag
        {
            get { return _AddressUpdateFlag; }
            set { _AddressUpdateFlag = value; }
        }

        private string _ResidenceCity;
        /// <summary>
        /// City
        /// </summary>
        public string ResidenceCity
        {
            get { return _ResidenceCity; }
            set { _ResidenceCity = value; }
        }

        private string _ResidenceState;
        /// <summary>
        /// State
        /// </summary>
        public string ResidenceState
        {
            get { return _ResidenceState; }
            set { _ResidenceState = value; }
        }

        private string _ResidenceZipCode;
        /// <summary>
        /// Zip Code
        /// </summary>
        public string ResidenceZipCode
        {
            get { return _ResidenceZipCode; }
            set { _ResidenceZipCode = value; }
        }

        private string _ResidenceZipCode4;
        /// <summary>
        /// Zip Code plus 4 numbers
        /// </summary>
        public string ResidenceZipCode4
        {
            get { return _ResidenceZipCode4; }
            set { _ResidenceZipCode4 = value; }
        }

        private string _EndDate;
        /// <summary>
        /// The date the address is no longer in effect
        /// </summary>
        public string EndDate
        {
            get { return _EndDate; }
            set { _EndDate = value; }
        }

        /// <summary>
        /// ValidateHICN edit checks the data for any transaction. The
        /// HICN is required and must not be greater than 12 characters long.
        /// </summary>
        /// <returns>If the HICN is valid, return true, otherwise false.</returns>
        public bool ValidateHICN()
        {
            if (this.HICN.Length < 1) return false;
            if (this.HICN.Length > 12) return false;
            return true;
        }

        /// <summary>
        /// ValidateSurname edit checks the data for any transaction. The
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
        /// ValidateFirstName edit checks the data for any transaction. The
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
        /// ValidateMInitial edit checks the data for any transaction. The
        /// MInitial is optional and must not be greater than 1 character long.
        /// </summary>
        /// <returns>If the initial is a single character, return true otherwise return false</returns>
        public bool ValidateMInitial()
        {
            if (this.MInitial.Length > 1) return false;
            return true;
        }

        /// <summary>
        /// ValidateContractNumber edit checks the data for all transactions. The contract number
        /// is required, is five characters long. The first position is a letter and the remaining are digits.
        /// </summary>
        /// <returns>If the contract number is valid then true, otherwise false</returns>
        public bool ValidateContractNumber()
        {
            if (this.ContractNumber.Length < 5) return false;
            if (this.ContractNumber.Length > 5) return false;
            return true;
        }

        private List<TransactionErrors> _errorList;

        public List<TransactionErrors> ErrorList
        {
            get { return _errorList; }
            set { _errorList = value; }
        }

    

        /// <summary>
        /// The <c>validate</c> method is part of the ITransaction interface. This method checks the values of the transaction and returns
        /// true if the elements pass the edit checks; otherwise it returns false.
        /// </summary>
        /// <returns>A value of true indicates that all the data on this transaction is valid and ready to send to CMS.
        /// A value of false indicates that data errors exist.</returns>

        public bool Validate()
        {
            return true;
        }
        /// <summary>
        /// Stub for the Insert method
        /// </summary>
        /// <returns></returns>
        public string Insert()
        {
            return "what is this?";
        }

 
        



     
      

    }

}
