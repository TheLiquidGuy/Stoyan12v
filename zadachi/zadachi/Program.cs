using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachi
{
    class Program
    {
        static void Main(string[] args)
        {
            zad8();
        }
        private static void zad1()
        {

            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                double c;
                c = (n + 1) / 2;
                Console.WriteLine(Math.Round(c));
            }
        }
        private static void zad7()
        {
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i <= n; i++)
                {
                    for (int x = 0; x < i; x++)
                    {
                        Console.Write('*');
                    }
                    Console.WriteLine();
                }
            }

        }
         private static void zad8()
        {
                while(true)
                {
                    int n = int.Parse(Console.ReadLine());
                    for (int i = 0; i <= n; i++)
                    {
                        for (int x = 1; x < i + 1; x++)
                        {
                            Console.Write(x);
                        }
                        Console.WriteLine();
                    }
                }
            }    

        }
    }

