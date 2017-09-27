using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char lastLetter = word.Last();
            
            if (lastLetter == 'y')
            {
                word = word.Remove(word.Length - 1);
                word += "ies";
            } 
            else if (lastLetter == 'o' || lastLetter == 's' ||
                     lastLetter == 'x' || lastLetter == 'z' )
            {
                //word.Remove(word.LastIndexOf(lastLetter));
                word += "es";
            }
            else if (word.Substring(word.Length - 2) == "ch" ||
                     word.Substring(word.Length - 2) == "sh")
            {
                word += "es";
            }
            else
            {
                word += "s";
            }
            Console.WriteLine(word);
        }
    }
}
