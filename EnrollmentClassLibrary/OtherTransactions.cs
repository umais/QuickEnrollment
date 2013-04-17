using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
   public  class OtherTransactions:ITransaction
    {

        public string Insert()
        {
            return "Hello I am the other One";
        }
    }
}
