using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2to10
{
    class Program
    {
        static void Main(string[] args)
        {
            string binary = Console.ReadLine();
            Console.WriteLine("{1}", binary, Convert.ToInt64(binary, 2));
            Console.ReadLine();
        }
    }
}
