using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "";
            string y = "";
            x = Console.ReadLine();
            y = Console.ReadLine();
            Phone Number1 = new Phone(x, y);
            Console.WriteLine(Number1.GetPhone());
            //y = Convert.ToString(Convert.ToInt32(x)*2);

            Console.WriteLine(Number1.PhoneNumber);
        }
    }
}
