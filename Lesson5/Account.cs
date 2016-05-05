using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Account
    {
        public Guid AccountID { get; readonly set; }
        public string Status { get; private set; }
        public string Owner { get; protected set; }
        public decimal Amount { get; protected set; }

        protected Account(string lastName, string firstName)
        {
            Owner = lastName + firstName;
            AccountID = Guid.NewGuid();
            Status = "open";
        }

        protected bool CloseAccount()
        {
            if (Amount == 0)
            {
                Status = "closed";
                return true;
            }
            else return false;
        }

        protected bool DepositMoney(decimal sum)
        {
            Amount = Amount + sum;
            return true;
        }
        protected bool WithdrawMoney(decimal sum)
        {
            if (Amount >= sum)
            {
                Amount = Amount - sum;
                return true;
            }
            else return false;
        }
    }
}
