using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnrollmentClassLibrary;

namespace FileCopyTest
{
    class ValidateEnrollment
    {
        ITransaction trans;
        public ValidateEnrollment(ITransaction r)
        {
            this.trans = r;
        }

        public void printTransaction()
        {
            Console.WriteLine("Test");
        }
    }
}
