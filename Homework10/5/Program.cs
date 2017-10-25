using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static bool IsExchangeable(string str1, string str2)
        {
            Dictionary<char, char> mappedChars = new Dictionary<char, char>();
            int lessChars = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < lessChars; ++i)
            {
                if (!mappedChars.ContainsKey(str1[i]))
                {
                    if (mappedChars.ContainsValue(str2[i]))
                    {
                        return false;
                    }
                    mappedChars[str1[i]] = str2[i];
                }
                else if (mappedChars[str1[i]] != str2[i])
                {
                    return false;
                }
            }
            string reminder = str1.Length > str2.Length ? str1.Substring(lessChars) :
                str2.Substring(lessChars);
            foreach (char ch in reminder.Where(x => !mappedChars.ContainsKey(x)))
            {
                if (!mappedChars.ContainsValue(ch))
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            string str1 = tokens[0];
            string str2 = tokens[1];
            Console.WriteLine("{0}", IsExchangeable(str1, str2) ? "true" : "false");
        }
    }
}
