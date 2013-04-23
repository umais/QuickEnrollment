using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>RxChangeTransaction</c> is the object for Rx changes. It inherits from
    /// the abstract class <c>BaseTransaction</c> and implements the interface ITransaction.
    /// </summary>
    class RxChangeTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "72" is used for Rx Change transactions
        /// </summary>
        public const string TransactionCode = "72";
    }
}
