using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, reverse = 0;

            a = int.Parse(Console.ReadLine());

            while (a != 0)

            {

                reverse = reverse * 10;

                reverse = reverse + a % 10;

                a = a / 10;

            }

            Console.WriteLine(reverse);

            Console.ReadLine();
        }
    }
}
