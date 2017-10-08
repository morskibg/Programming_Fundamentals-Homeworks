using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14
{
    class Program
    {
        static int CoutTrailinZeroes(int toWhichFactorial)
        {
            BigInteger factorial = 1;
            int counter = 0;
            for (int i = 1; i <= toWhichFactorial; i++)
            {
                factorial *= i;
            }
            
            while (factorial % 10 == 0)
            {
                ++counter;
                factorial /= 10;
            }

            return counter;
        }


        static void Main(string[] args)
        {
            int whichFactorial = int.Parse(Console.ReadLine());
            Console.WriteLine(CoutTrailinZeroes(whichFactorial));
        }
    }
}
