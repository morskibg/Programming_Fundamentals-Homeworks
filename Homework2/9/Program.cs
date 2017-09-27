using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num = 0;
            int counter = 0;
            while (Int32.TryParse(input, out num))
            {
                ++counter;
                input = Console.ReadLine();
            }
            Console.WriteLine(counter);
        }
    }
}
