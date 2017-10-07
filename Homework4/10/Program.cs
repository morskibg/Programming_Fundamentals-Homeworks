using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int difference = int.Parse(Console.ReadLine());
            int diffCounter = 0;
            for (int i = 0; i < Arr.Length; ++i)
            {
                for (int j = 0; j < Arr.Length; ++j)
                {
                    if (Arr[i] - Arr[j] == difference)
                    {
                        ++diffCounter;
                    }
                }
            }
            Console.WriteLine(diffCounter);
        }
    }
}
