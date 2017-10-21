using System;
using System.Collections.Generic;
using System.IO;
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
            string[] input = File.ReadAllLines("input.txt");
            string prevName = "";
            int idx = 0;
            while (input[idx] != "stop")
            {
                if (input[idx].Contains("@"))
                {
                    char[] delim = ".".ToCharArray();
                    string[] tokens = input[idx].ToLower().Split(delim, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (tokens.Last() != "us" && tokens.Last() != "uk")
                    {
                        users[prevName] = input[idx];
                    }
                }
                else
                {
                    prevName = input[idx];
                }
                ++idx;
            }
            File.WriteAllText("output.txt", "");
            foreach (var user in users)
            {
                File.AppendAllText("output.txt", $"{user.Key} -> {user.Value}" + Environment.NewLine);
            }
        }
    }
}
