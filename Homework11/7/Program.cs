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
            Regex decodingSpaces = new Regex("%20|\\+");
            Regex removeExtraInsideSpaces = new Regex("\\s{2,9999}");
            
            string pattern = @"((?<=\&|^).*?(?=\=))\=+(.*?(?=\&|$))";
            while (input != "END")
            {
                Dictionary<string, string> fieldValues = new Dictionary<string, string>();
                MatchCollection matchedFieldValues = Regex.Matches(input, pattern);
                int count = matchedFieldValues.Count;
                for (int i = 0; i < count; i++)
                {
                    int matchGroupsCounter = matchedFieldValues[i].Groups.Count;
                    for (int j = 1; j < matchGroupsCounter - 1; j += 2)
                    {

                        string decodedKey = decodingSpaces
                            .Replace(matchedFieldValues[i].Groups[j].ToString(), " ")
                            .Trim();
                        decodedKey = removeExtraInsideSpaces.Replace(decodedKey, " ");
                        if (decodedKey.Contains("?"))
                        {
                            decodedKey = decodedKey.Substring(decodedKey.IndexOf("?") + 1);
                        }
                        string decodedValue = decodingSpaces
                            .Replace(matchedFieldValues[i].Groups[j + 1].ToString(), " ")
                            .Trim();
                        decodedValue = removeExtraInsideSpaces.Replace(decodedValue, " ");
                        if (decodedValue.Contains("?"))
                        {
                            decodedValue = decodedValue.Substring(decodedValue.IndexOf("?") + 1);
                        }
                        if (!fieldValues.ContainsKey(decodedKey))
                        {
                            fieldValues[decodedKey] = decodedValue;
                        }
                        else
                        {
                            fieldValues[decodedKey] += ", " + decodedValue;
                        }                        
                    }
                }
                foreach (var item in fieldValues)
                {
                    Console.Write($"{item.Key}=[{item.Value}]");
                }
                Console.WriteLine();
                input = Console.ReadLine();
            }

        }
    }
}
