using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы N*M");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n,m];
            Random randomNumbers = new Random();
            int[] array = new int[n];
            for (int i=0; i<n; i++)
            {
                for (int j=0; j<m; j++)
                {
                    matrix[i,j] = randomNumbers.Next();
                }
            }
            for (int i=0; i < n; i++)
            {
                array[i] = matrix[i, 0];
                for (int j = 0; j < m; j++)
                {
                    if (matrix[i, j] < array[i])
                    {
                        array[i] = matrix[i, j];
                    }
                }
            }
            Array.Sort(array);
            Console.WriteLine("Отсортированный массив минимальных элементов строк матрицы N*M");
            foreach (int item in array)
                Console.Write(item + " ");

        }
    }
}
