using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentClassLibrary.Models;

namespace EnrollmentClassLibrary.BusinessRules
{
    abstract public class ValidateBaseClass:ITransactionRules
    {

        public static string NULL = "";
        /// <summary>
        /// The property transaction contains the model for the EnrollmentTransaction.
        /// </summary>
        public EnrollmentTransaction transaction { get; set; }
        protected BasicEditChecks Edits = new BasicEditChecks();

        /// <summary>
        /// This constructor creates a new empty transaction, transaction properties must be set
        /// later by other classes.
        /// </summary>
        public ValidateBaseClass()
        {
            transaction = new EnrollmentTransaction();
        }

        /// <summary>
        /// The constructor accepts a transaction that is cast into a type EnrollmentTransaction.
        /// </summary>
        /// <param name="TheTransaction">The parameter TheTransaction contains an enrollment transaction.</param>
        public ValidateBaseClass(EnrollmentTransaction TheTransaction)
        {
            transaction = TheTransaction;
        }

        /// <summary>
        /// The <c>ApplyRules</c> method executes the validations for the transaction.
        /// </summary>
        /// <returns>If the transaction is valid then return true, otherwise false.</returns>
        abstract public bool ApplyRules();

        }
}
