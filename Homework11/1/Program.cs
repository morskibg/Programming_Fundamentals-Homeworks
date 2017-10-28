using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<=\s|^)\b[a-z0-9][._-]*[a-z0-9]+[._-]*[a-z0-9]+(?![._-])\@[a-z0-9]+[._-]*[a-z0-9]+\.\w+(\.\w+)?";
            MatchCollection matchedEmails = Regex.Matches(input, pattern);
            foreach ( Match mail in matchedEmails)
            {
                Console.WriteLine(mail);
            }
            
        }
    }
}
