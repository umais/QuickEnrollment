using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
   public class EnrollmentRepository:ITransactionRepository
    {
       //This is temporary static collection just for testing purposes. will be replaced soon by a list getting data from actual Database.
        public static List<BaseTransaction> transactionList=
            new List<BaseTransaction>
            {new EnrollmentTransaction{FirstName="Umais",Surname="Siddiqui",TransactionID="1234"}};

        public static EnrollmentRepository repo = new EnrollmentRepository();
        public static EnrollmentRepository getEnrollmentRepo()
        {
            return repo;
        }
        public void Insert(BaseTransaction newTransaction) {
            transactionList.Add(newTransaction);
        }

       
        public List<BaseTransaction> getAll() { return transactionList; }
        public void Update(BaseTransaction updatedTransaction) {
            BaseTransaction matches = transactionList.Where(t => t.TransactionID == updatedTransaction.TransactionID).First();
            if (matches != null)
            {
                transactionList.Remove(matches);
                transactionList.Add(updatedTransaction);
            }

        }
        public BaseTransaction get(string id) {
            var matches = transactionList.Where(t => t.TransactionID == id);
            return matches.Count() > 0 ? matches.First() : null;
           
        }
    }
}
