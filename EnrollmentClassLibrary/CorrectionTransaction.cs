using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>CorrectionTransaction</c> is the object for correction transactions.
    /// It inherits from the abstract class <c>BaseTransaction</c> and implements the interface ITransaction.
    /// </summary>
    class CorrectionTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "01" is used for corrections
        /// </summary>
        public const string TransactionCode = "01";
    }
}
