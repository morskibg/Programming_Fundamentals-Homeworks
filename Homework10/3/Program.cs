using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static string GetUnicodeString(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                sb.Append("\\u");
                sb.Append(String.Format("{0:x4}", (int)c));
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string asciiString = Console.ReadLine();
            string unicodeString = GetUnicodeString(asciiString);
            Console.WriteLine(unicodeString);
            
            int t = 0;
        }
    }
}
