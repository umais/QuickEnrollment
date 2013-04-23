using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>MPPCancelTransaction</c> is the object for backing MPP enrollment transactions.
    /// It inherits from the abstract class <c>BaseTransaction</c> and implements the interface ITransaction.
    /// </summary>
    class MPPEnrollmentTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "83" is used for MPP Enrollment Cancellations
        /// </summary>
        public const string TransactionCode = "83";
    }
}
