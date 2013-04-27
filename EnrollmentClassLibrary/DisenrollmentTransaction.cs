using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The class <c>DisenrollmentTransaction</c> is the object for dis-enrollments. It inherits from
    /// the abstract class <c>BaseTransaction</c> and implements the interface ITransaction.
    /// </summary>
    class DisenrollmentTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "51" is used for all dis-enrollment transactions
        /// </summary>
        public const string TransactionCode = "51";

   
    }
}
