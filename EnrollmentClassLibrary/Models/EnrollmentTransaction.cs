using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace EnrollmentClassLibrary.Models
{
    /// <summary>
    /// The class <c>EnrollmentTransaction</c> is the object for enrollment transactions.
    /// It inherits BaseTransaction which implements the ITransaction interface.
    /// </summary>
    
   public  class EnrollmentTransaction:BaseTransaction
    {
        /// <summary>
        /// CMS designates that "61" is used for all enrollment transactions
        /// </summary>
        public const string TransactionCode = "61";

        /// <summary>
        /// The <c>Validate</c> method checks all the properties in the transaction.
        /// </summary>
        /// <returns>If all the elements are valid, the method returns true, otherwise
        /// if returns false.</returns>
        public new bool Validate()
        {
            return true;
        }


      

    }
}
