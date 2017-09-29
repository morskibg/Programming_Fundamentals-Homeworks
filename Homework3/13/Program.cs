using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Console.ReadLine()[0];
            if (char.IsDigit(input))
            {
                Console.WriteLine("digit");
            }
            else if (input == 'a' || input == 'o' || input == 'e' ||
                     input == 'i' || input == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
