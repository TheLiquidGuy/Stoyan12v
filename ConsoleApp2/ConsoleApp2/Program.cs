using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Int32.Parse(Console.ReadLine());
            if ((a % 2) == 0)

            {

                Console.WriteLine("even {0}", a);

            }
            else

            {

                Console.WriteLine("odd {0}", a);

            }
        }
    }
}
