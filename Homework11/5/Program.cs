using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyString = Console.ReadLine();
            string textString = Console.ReadLine();
            string keyPattern = @"^([^\\|<]*).*?([^\\|<]*)$";
            MatchCollection keys = Regex.Matches(keyString, keyPattern);
            string startKey = keys[0].Groups[1].ToString();
            string endKey = keys[0].Groups[2].ToString();
            string textPattern = $@"(?<={startKey})(.*?)(?={endKey})";
            MatchCollection matched = Regex.Matches(textString, textPattern);
            StringBuilder sb = new StringBuilder();
            foreach (Match m in matched )
            {
                sb.Append(m.ToString());
            }
            if (sb.Length > 0)
            {
                Console.WriteLine(sb.ToString());
            }
            else
            {
                Console.WriteLine("Empty result");
            }
        }
    }
}
