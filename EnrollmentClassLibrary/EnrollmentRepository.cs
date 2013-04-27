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
        public static List<ITransaction> transactionList=
            new List<ITransaction>
            {new EnrollmentTransaction{FirstName="Umais",Surname="Siddiqui",TransactionID="1234"}};

        public static EnrollmentRepository repo = new EnrollmentRepository();
        public static EnrollmentRepository getEnrollmentRepo()
        {
            return repo;
        }
        public void Insert(ITransaction newTransaction) {
            transactionList.Add(newTransaction);
        }
        public List<ITransaction> getAll() { return transactionList; }
        public void Update(ITransaction updatedTransaction) { 
        
        }
        public ITransaction get(string id) {
            return new EnrollmentTransaction();
           // ITransaction t=fromtransactionList.Where(t1=>t
        }
    }
}
