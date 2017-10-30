using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                var matches = Regex
                    .Matches(Console.ReadLine(), @"((?<=<p>).*?(?=<\/p>))");

                var result = new StringBuilder();

                foreach (Match match in matches)
                {
                    result.Append(string.Concat(Regex
                        .Replace(match.Value, @"[^a-z]+", " ")
                        .ToCharArray()
                        .Select(chr => (chr >= 'a' && chr <= 'z')
                            ? (char)('a' + (chr - 'a' + 13) % 26)
                            : chr)));
                }

                Console.WriteLine(result.ToString());
            }
        }
    }
}
