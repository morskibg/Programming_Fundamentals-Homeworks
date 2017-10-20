using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();
            string input = Console.ReadLine();
            string prevName = "";
            while (input != "stop")
            {
                if (input.Contains("@"))
                {
                    char[] delim = ".".ToCharArray();
                    string[] tokens = input.ToLower().Split(delim, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (tokens.Last() != "us" && tokens.Last() != "uk")
                    {
                        users[prevName] = input;
                    }
                }
                else
                {
                    prevName = input;
                }
                input = Console.ReadLine();
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} -> {user.Value}");
            }
        }
    }
}
