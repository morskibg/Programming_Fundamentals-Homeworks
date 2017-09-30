using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
            int startSymbol = int.Parse(Console.ReadLine());
            int endSymbol = int.Parse(Console.ReadLine());
            for (int i = (int) startSymbol; i <= (int) endSymbol; ++i)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
