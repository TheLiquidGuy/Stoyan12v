using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a =
                {
                {5,24,7,5 },
                {3,1,35,6},
                {1,6,234,67},
                {123,31,13,87}
                };
            int n = (int)Math.Sqrt(a.Length); // po redove
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]}");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
