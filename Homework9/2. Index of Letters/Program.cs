using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = File.ReadAllText("input.txt").ToLower().Trim();
            File.WriteAllText("output.txt", "");
            foreach (char ch in inputWord)
            {
                File.AppendAllText("output.txt", $"{ch} -> {(int)(ch - 'a')}" + Environment.NewLine);
            }
        }
    }
}
