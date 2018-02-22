using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reversing_sentence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] words = text.Split(' ');
            int k = words.Length - 1;
            for (int i = k; i >= 0; i--)
            {
                Console.Write(words[i] + " ");

            }

            Console.ReadLine();

        }
    }
}
