using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
   public class MedicareTransaction:ITransaction
    {
        Member member { get; set; }
        string TransactionCode { get; set; }


       public  MedicareTransaction()
        {
            member = new Member();
            member.FirstName = "Umais";
            member.LastName = "siddiqui";
        }
        public string Insert()
        {
            return member.FirstName;
        }
    }
}
