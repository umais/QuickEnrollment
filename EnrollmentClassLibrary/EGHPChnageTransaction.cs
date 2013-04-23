using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>EGHPChangeTransaction</c> is the object for EGHP change transactions.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    class EGHPChnageTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "74" is used for EGHP flag change transactions
        /// </summary>
        public const string TransactionCode = "74";
    }
}
