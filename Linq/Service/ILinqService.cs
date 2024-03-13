using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq.Service
{
    public interface ILinqService
    {
        void GroupByN(int n);
        void JoinLists();
        void GroupByAlphabet();

        void GroupStatesByN(int n);
        void GroupStatesByAlphabet();
    }
}
