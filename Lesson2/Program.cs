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
            /*//task1 Ввести с консоли N чисел. Вывести сумму, максимальное, минимальное значения,
            //количество четных чисел, произведение нечетных чисел.      
            int max = 0;
            int min = 0;
            int sum = 0;
            int unit1 = 1; // произведение нечетных
            int count1 = 0; // количество нечетных
            int count2 = 0; // количество четных
            int x = 0;
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                x = Convert.ToInt32(Console.ReadLine());
                if (i == 0)
                {
                    min = max = x;
                }
                if (x > max)
                {
                    max = x;
                }
                if (x < min)
                {
                    min = x;
                }
                sum = sum + x;
                if (x % 2 == 0)
                {
                    count2++;
                }
                else
                {
                    count1++;
                    unit1 = unit1 * x;
                }
                if (count1 == 0)
                {
                    unit1 = 0;
                }
            }
            Console.WriteLine(string.Format("sum: {0}, max: {1}, min: {2}, even count: {3}, odd product: {4}", sum, max, min, count2, unit1));
            Console.ReadLine();*/

            //task2 Ввести с консоли N чисел. Отсортировать. Вывести результат. N - задается с консоли
            int m = 0;
            int z = 0;
            int[] num = new int[m];
            for (int i = 0; i < m; i++)
            {
                z = Convert.ToInt32(Console.ReadLine());
                num[i] = z;
            }
            Array.Sort(num);
            for (int i = 0; i < m; i++)
            {
                Console.WriteLine(num[i]);
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
