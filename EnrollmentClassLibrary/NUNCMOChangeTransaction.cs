using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>NUNCMOChangeTransaction</c> is the object for number of uncovered month changes.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    class NUNCMOChangeTransaction : BaseTransaction
    {
        /// <summary>
        /// CMS designates that "73" is used for all enrollment transactions
        /// </summary>
        public const string TransactionCode = "73";
    }
}
