using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int res = (n) & (int.MaxValue-1);
            Console.WriteLine(res);
            
            /* task2
            int n = Convert.ToInt32(Console.ReadLine());
            int i = Convert.ToInt32(Console.ReadLine());
            int res = (n>>i)&1;
            Console.WriteLine(res);*/

            /* task1
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int sum = n + m;
            Console.WriteLine(sum);*/
        }
    }
}
