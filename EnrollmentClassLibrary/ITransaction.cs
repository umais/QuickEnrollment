using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
///
/// The interface for transactions gaurantees that classes implement the validate method
///
    public interface ITransaction
    {
        string Insert();
    }
}
