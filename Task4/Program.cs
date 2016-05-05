using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность массива");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[n];
            Random randomNumbers = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = randomNumbers.Next();
                mas[4] = 555;
            }
            Console.WriteLine("Введите число");
            int m = Convert.ToInt32(Console.ReadLine());
            if (Array.IndexOf(mas, m) < 0)
            {
                Console.WriteLine("No");
            }
            else Console.WriteLine("Yes");
        }
    }
}
