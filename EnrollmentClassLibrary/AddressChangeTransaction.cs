using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>AddressChangeTransaction</c> is the object for Residence Address Change transactions.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    class AddressChangeTransaction : BaseTransaction
    {
        /// <summary>
        /// CMS designates that "76" is used for change of address transactions
        /// </summary>
        public const string TransactionCode = "76";
    }
}
