using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        public static int ReadInt()
        {
            int x = 0;
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        public static void WhiteInt(int[] numbers)
        {
            int n = (numbers.Length-1);
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        public static double ReadDouble()
        {
            double x;
            x = Convert.ToDouble(Console.ReadLine());
            return x;
        }
        static void Main(string[] args)
        {
            int y = ReadInt();
                   
        }
    }
}
