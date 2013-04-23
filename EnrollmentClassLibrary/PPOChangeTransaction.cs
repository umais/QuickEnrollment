using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>PPOChangeTransaction</c> is the object for Premium Payment Option transactions.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    class PPOChangeTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "75" is used for PPO change transactions
        /// </summary>
        public const string TransactionCode = "75";
    }
}
