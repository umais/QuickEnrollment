using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    /// <summary>
    /// The <c>ITransaction</c> iterface assures that all transaction classes implement common methods.
    /// </summary>
    public interface ITransaction
    {
        /// <summary>
        /// The <c>validate</c> method performas a global validation of all the properties of the transaction.
        /// </summary>
        /// <returns>A value of true indicates that all the data on this transaction is valid and ready to send to CMS.
        /// A value of false indicates that data errors exist.</returns>
        bool Validate();

        /// <summary>
        /// Stub for the insert method
        /// </summary>
        /// <returns></returns>
        string Insert();
    }
}
