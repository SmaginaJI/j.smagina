using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class TransactionAccount : Account
    {
        public TransactionAccount(string lastName, string firstName)
            : base(lastName, firstName)
        {
        }
    }
}
