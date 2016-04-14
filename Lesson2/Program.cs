using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] num = new int[n];
            int x = 0;
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                num[i] = x;
            }
            Array.Sort(num);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(num[i]);
            }

            /* task1
            int max = 0;
            int min = 0;
            int sum = 0;
            int unit1 = 0;
            int count2 = 0;
            int x = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
                sum = sum + x;
                if (i % 2 == 0)
                {
                    count2++;
                }
                else
                {
                    unit1 = unit1 * 1;
                }
            }
            Console.WriteLine(string.Format("sum: {0}, multi: {1}", sum, unit1));
            //Console.ReadLine();
            */
        }
    }
}
