using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Client
    {
        protected long ClientID;
        protected int Phone;
        protected float OrderAmount;

        public Client(long clientID, int phone)
        {
            ClientID = clientID;
            Phone = phone;
            OrderAmount = 0;
        }

    }
}
