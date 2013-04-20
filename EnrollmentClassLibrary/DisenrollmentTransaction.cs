using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    class DisenrollmentTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "51" is used for all dis-enrollment transactions
        /// </summary>
        public const string TransactionCode = "51";
    }
}
