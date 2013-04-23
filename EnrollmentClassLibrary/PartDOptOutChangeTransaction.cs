using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>PartDOptOutChangeTransaction</c> is the object for Part D Opt-out change transactions.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    class PartDOptOutChangeTransaction : BaseTransaction
    {
        /// <summary>
        /// CMS designates that "79" is used for Part D opt out transactions
        /// </summary>
        public const string TransactionCode = "79";
    }
}
