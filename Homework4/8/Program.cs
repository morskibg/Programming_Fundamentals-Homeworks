using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] occurences = new int[Arr.Length];
            for (int i = 0; i < Arr.Length; ++i)
            {
                int currCounter = 0;
                for (int j = 0; j < Arr.Length; ++j)
                {
                    if (Arr[i] == Arr[j])
                    {
                        ++currCounter;
                    }
                }
                occurences[i] = currCounter;
            }
            int maxOccurance = occurences.Max();
            
            for (int i = 0; i < occurences.Length; ++i)
            {
                if (occurences[i] == maxOccurance)
                {
                    Console.WriteLine(Arr[i]);
                    return;
                }
            }
            
        }
    }
}
