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
            
            char[] arr1 = Console.ReadLine().ToLower().Split(' ').Select(x => x[0]).ToArray();
            char[] arr2 = Console.ReadLine().ToLower().Split(' ').Select(x => x[0]).ToArray();
            int idx = 0;
            int minSize = Math.Min(arr1.Length, arr2.Length);
            while (true)
            {
                if (arr1[idx] > arr2[idx])
                {
                    Console.WriteLine($"{string.Join("", arr2)}");
                    Console.WriteLine($"{string.Join("", arr1)}");
                    return;
                }
                else if (arr1[idx] < arr2[idx])
                {
                    Console.WriteLine($"{string.Join("", arr1)}");
                    Console.WriteLine($"{string.Join("", arr2)}");
                    return;
                }
                ++idx;
            }
            
        }
    }
}
