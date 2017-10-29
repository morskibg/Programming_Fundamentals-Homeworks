using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"((?<=^|\s|[()\/\\])[A-Za-z]\w{2,24})\b";
            MatchCollection matchenUserNames = Regex.Matches(Console.ReadLine(), pattern);
            int maxLength = Int32.MinValue;
            StringBuilder[] maxLenCouple = new StringBuilder[2]
            {
                new StringBuilder(), 
                new StringBuilder()
            };
            for (int i = 0; i < matchenUserNames.Count - 1; i++)
            {
                int innerSumLen = matchenUserNames[i].Length + matchenUserNames[i + 1].Length;
                if (innerSumLen > maxLength)
                {
                    maxLength = innerSumLen;
                    maxLenCouple[0].Clear();
                    maxLenCouple[0].Append(matchenUserNames[i]);
                    maxLenCouple[1].Clear();
                    maxLenCouple[1].Append(matchenUserNames[i + 1]);
                }
            }
            Console.WriteLine(maxLenCouple[0]);
            Console.WriteLine(maxLenCouple[1]);
        }
    }
}
