using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadachi2
{
    class Program
    {
        static void Main(string[] args)
        {
            zad4();
        }
        static void zad6()
        {
            int n = int.Parse(Console.ReadLine());
            int m = 1;
            for (int o = 1; o <= n; o++)
            {
                m = m * o;
            }
            Console.WriteLine(m);
            Console.ReadLine();
        }
        static void zad3()
        {
            int n = int.Parse(Console.ReadLine());
            for (int m = 0; m <= n; m++)
            {
                int e = m % 2;
                if (e == 0)
                {
                    Console.Write(m);
                }
                Console.ReadLine();
            }
        }


        static void zad4()

        {
            int n = int.Parse(Console.ReadLine());
            int sumodd = 0;
            for (int m = 0; m <= n; m++)

            {
                int e = m % 2;
                if (e != 0)

                {
                    sumodd = sumodd + m;
                    {
                        
                    }
                }
            }
            Console.WriteLine(sumodd);
            Console.ReadLine();
        }
    }
}


