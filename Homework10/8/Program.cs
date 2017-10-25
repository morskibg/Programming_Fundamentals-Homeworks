using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static int FindAlphaberPosition(char ch)
        {
            if ((int)ch >= 65 && (int)ch <= 90)
            {
                return (int)(ch - '@');
            }
            else if ((int)ch >= 97 && (int)ch <= 122)
            {
                return (int)(ch - '`');
            }
            return -1;
        }
        static double Calaculator(string str)
        {
            double workingNum = 0;
            char firstLetter = str.First();
            char lastLetter = str.Last();
            long num = long.Parse(str.Substring(1, str.Length - 2));
            if (char.IsUpper(firstLetter))
            {
                workingNum = num / (double)FindAlphaberPosition(firstLetter);
            }
            else
            {
                workingNum = num * FindAlphaberPosition(firstLetter);
            }
            if (char.IsUpper(lastLetter))
            {
                workingNum -= FindAlphaberPosition(lastLetter);
            }
            else
            {
                workingNum += FindAlphaberPosition(lastLetter);
            }
            return workingNum;
        }
        static void Main(string[] args)
        {
            char[] delim = " \t".ToCharArray();
            string[] input = Console.ReadLine().Split(delim, StringSplitOptions.RemoveEmptyEntries).ToArray();

            double sum = 0;
            for (int i = 0; i < input.Length; ++i)
            {
                double tempResult = Calaculator(input[i].Trim());
                sum += tempResult;
            }
            Console.WriteLine($"{sum:f2}");
        }
    }
}
