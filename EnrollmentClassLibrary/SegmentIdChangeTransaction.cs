using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>SegmentIdChangeTransaction</c> is the object for Segment ID change transactions.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    class SegmentIdChangeTransaction : BaseTransaction
    {
        /// <summary>
        /// CMS designates that "77" is used for segment id change transactions
        /// </summary>
        public const string TransactionCode = "77";
    }
}
