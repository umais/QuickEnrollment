using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>MPPOptOutTransaction</c> is the object for updating the MPP Opt-out.
    /// It inherits from the abstract class <c>BaseTransaction</c> and implements the interface ITransaction.
    /// </summary>
    class MPPOptOutTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "83" is used for MPP Opt Out update transaction
        /// </summary>
        public const string TransactionCode = "83";
    }
}
