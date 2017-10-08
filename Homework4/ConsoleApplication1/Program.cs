using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static string GetWord(long num)
        {
            long lastDigit = num % 10;
            if (lastDigit == 0)
            {
                return "zero";
            }
            else if (lastDigit == 1)
            {
                return "one";
            }
            else if (lastDigit == 2)
            {
                return "two";
            }
            else if (lastDigit == 3)
            {
                return "three";
            }
            else if (lastDigit == 4)
            {
                return "four";
            }
            else if (lastDigit == 5)
            {
                return "five";
            }
            else if (lastDigit == 6)
            {
                return "six";
            }
            else if (lastDigit == 7)
            {
                return "seven";
            }
            else if (lastDigit == 8)
            {
                return "eight";
            }
            else
            {
                return "nine";
            }

        }
        static void Main(string[] args)
        {

            Console.WriteLine(GetWord(Math.Abs(long.Parse(Console.ReadLine()))));

        }
    }
}
