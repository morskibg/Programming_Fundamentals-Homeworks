using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] delimiter = " /\\()".ToCharArray();
            string[] rawUserNAmes =
                Console.ReadLine().Split(delimiter, StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> validatedUserNames = new List<string>();
            string pattern = @"^[a-zA-Z]\w{2,24}$";
            foreach (var userName in rawUserNAmes)
            {
                Regex rg = new Regex(pattern);
                Match currMatch = rg.Match(userName);
                if (currMatch.Success)
                {
                    validatedUserNames.Add(userName);
                }
            }
            string[] longestLenCouple = new string[2];
            int MaxLengthSum = Int32.MinValue;
            for (int i = 0; i <= validatedUserNames.Count - 2; i++)
            {
                int innerSum = validatedUserNames[i].Length + validatedUserNames[i + 1].Length;
                if (innerSum > MaxLengthSum)
                {
                    longestLenCouple[0] = validatedUserNames[i];
                    longestLenCouple[1] = validatedUserNames[i + 1];
                    MaxLengthSum = innerSum;
                }
            }
            Console.WriteLine(longestLenCouple[0]);
            Console.WriteLine(longestLenCouple[1]);
           
        }
    }
}
