using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    class EnrollmentTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "61" is used for all enrollment transactions
        /// </summary>
        public const string TransactionCode = "61";
    }
}
