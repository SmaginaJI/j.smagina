using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class IndividualEntreprenuer : Client
    {
        private string FirstName;
        private string LastName;
        private DateTime Birthday;

        public IndividualEntreprenuer(string firstName, string lastName, DateTime birthday, long clientID, int phone)
            : base(clientID, phone)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public override string OrderInformation()
        {
            return string.Format("{0} {1}, {2} года рождения, сумма заказа: ", FirstName, LastName, Birthday.Year) + base.OrderInformation();
        }
    }
}
