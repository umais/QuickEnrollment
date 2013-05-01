using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentClassLibrary.Models;

namespace EnrollmentClassLibrary.BusinessRules
{
    public interface ITransactionRules
    {
        //ITransaction transaction {get; set;}
         bool ApplyRules();
        //void ValidateTransaction(EnrollmentApplication App);
        //void UpdateTransaction(EnrollmentApplication App);
        //void RemoveTransaction(EnrollmentApplication App);
    }
}
