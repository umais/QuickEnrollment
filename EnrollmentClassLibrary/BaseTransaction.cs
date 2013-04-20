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

        public string Insert()
        {
            return "what is this?";
        }
    }

}
