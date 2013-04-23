using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>CancelEnrollmentTransaction</c> is the object for backing out an enrollment. It inherits from
    /// the abstract class <c>BaseTransaction</c> and implements the interface ITransaction.
    /// </summary>
    class CancelEnrollmentTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "80" is used for cancel enrollment transactions
        /// </summary>
        public const string TransactionCode = "80";
    }
}
