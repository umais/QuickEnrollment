using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentClassLibrary
{
    public interface ITransactionRepository
    {
        
        void Insert(BaseTransaction newTrans);
        List<BaseTransaction> getAll();
        BaseTransaction get(string id);
        void Update(BaseTransaction updatedTrans);
    }
}
