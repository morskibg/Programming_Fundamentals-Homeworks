using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string input = Console.ReadLine();
            while (input != "END")
            {
                Dictionary<string, string> fieldValues = new Dictionary<string, string>();
                string pattern = @"((?<=\&|^).*?(?=\=))\=+(.*?(?=\&|$))";
                MatchCollection matchedFieldValues = Regex.Matches(input, pattern);
                int count = matchedFieldValues.Count;
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < count; i++)
                {
                    int groupCount = matchedFieldValues[i].Groups.Count - 1;
                    for (int j = 1; j <= groupCount; ++j)
                    {
                        if (j % 2 != 0)
                        {
                            sb.Append(matchedFieldValues[i].Groups[j]);
                        }
                        else
                        {
                            sb.Append("=[");
                            sb.Append(matchedFieldValues[i].Groups[j]);
                            sb.Append("]");
                        }
                    }
                    Console.WriteLine(sb);
                }
                
                input = Console.ReadLine();
            }
        }
    }
}
