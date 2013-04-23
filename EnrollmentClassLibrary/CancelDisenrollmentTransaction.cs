using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>CancelDisenrollmentTransaction</c> is the object for backing out dis-enrollment transactions.
    /// It inherits from the abstract class <c>BaseTransaction</c> and implements the interface ITransaction.
    /// </summary>
    class CancelDisenrollmentTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "81" is used for cancel dis-enrollment transactions
        /// </summary>
        public const string TransactionCode = "81";
    }
}
