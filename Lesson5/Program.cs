using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualEntreprenuer Person = new IndividualEntreprenuer("Иванов", "Иван", DateTime.Now,1,3562255);
            Person.OrderAmount = 1022.1F;
            Console.WriteLine(Person.OrderInformation());
        }
    }
}
