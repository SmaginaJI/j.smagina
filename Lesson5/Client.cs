using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Client
    {
        protected long clientID;
        protected int phoneNumber;
        protected float orderAmount;

        public Client(long client, int phone)
        {
            clientID = client;
            phoneNumber = phone;
            orderAmount = 0;
        }

        public float OrderAmount
        {
            get { return orderAmount; }
            set { orderAmount = value; }
        }
        
        public virtual string OrderInformation()
        {
            return Convert.ToString(orderAmount);
        }
    }
}
