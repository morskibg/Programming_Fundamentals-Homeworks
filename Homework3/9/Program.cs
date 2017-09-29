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
            char[] inputLetters = new char[3];
            for (int i = 0; i < 3; ++i)
            {
                inputLetters[i] = Console.ReadLine()[0];
            }
            for (int i = 2; i >= 0; --i)
            {
                Console.Write(inputLetters[i]);
            }

        }
    }
}
