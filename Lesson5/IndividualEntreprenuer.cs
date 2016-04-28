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

        // метод вывода данных по клиентам, потом он будет переопределен в дочерних классах

    }
}
