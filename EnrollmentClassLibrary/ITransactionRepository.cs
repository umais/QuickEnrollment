using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    public interface ITransactionRepository
    {
        
        void Insert(ITransaction newTrans);
        List<ITransaction> getAll();
        ITransaction get(string id);
        void Update(ITransaction updatedTrans);
    }
}
