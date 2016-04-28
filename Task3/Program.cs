using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матриц");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix1 = new int[n, n];
            int[,] matrix2 = new int[n, n];
            int[,] matrixSum = new int[n, n];
            Random randomNumbers = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix1[i, j] = randomNumbers.Next();
                    matrix2[i, j] = randomNumbers.Next();
                    matrixSum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
        }
    }
}
