using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>PartCPremiumChangeTransaction</c> is the object for Part C Premium change transactions.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    class PartCPremiumChangeTransaction : BaseTransaction
    {
        /// <summary>
        /// CMS designates that "78" is used for Part C Premium change transactions
        /// </summary>
        public const string TransactionCode = "78";
    }
}
