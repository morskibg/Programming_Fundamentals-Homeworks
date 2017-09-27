using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int ingrCounter = 0;
            while (input != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {input}.");
                ++ingrCounter;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Preparing cake with {ingrCounter} ingredients.");
        }
    }
}
