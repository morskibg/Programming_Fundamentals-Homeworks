using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string seekWord = Console.ReadLine().Trim();
            string uniquePattern = $@"\b{seekWord}\b";
            Regex rg = new Regex(uniquePattern);
            string[] sentences = Console.ReadLine()
                .Split(new char[] {'.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .Where(x => rg.IsMatch(x))
                .ToArray();
            foreach (var sentance in sentences)
            {
                Console.WriteLine(sentance);
            }
            
            
        }
    }
}
