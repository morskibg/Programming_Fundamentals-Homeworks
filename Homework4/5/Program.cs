using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void PrintFirstArr(char[] arr1, char[] arr2)
        {
            Console.WriteLine($"{string.Join("", arr1)}");
            Console.WriteLine($"{string.Join("", arr2)}");
           
        }
        static void PrintSecondArr(char[] arr1, char[] arr2)
        {
            Console.WriteLine($"{string.Join("", arr2)}");
            Console.WriteLine($"{string.Join("", arr1)}");
            
        }
        static void Main(string[] args)
        {
            
            char[] arr1 = Console.ReadLine().ToLower().Split(' ').Select(x => x[0]).ToArray();
            char[] arr2 = Console.ReadLine().ToLower().Split(' ').Select(x => x[0]).ToArray();
            int idx = 0;
            int minSize = Math.Min(arr1.Length, arr2.Length);
            while (idx < minSize)
            {
                if (arr1[idx] > arr2[idx])
                {
                    PrintSecondArr(arr1, arr2);
                    return;
                }
                else if (arr1[idx] < arr2[idx])
                {
                    PrintFirstArr(arr1, arr2);
                    return;
                }
                ++idx;
            }
            if (arr1.Length == arr2.Length)
            {
                PrintFirstArr(arr1, arr2);
                return;
            }
            else if (arr1.Length > arr2.Length)
            {
                PrintSecondArr(arr1, arr2);
                return;
            }
            else
            {
                PrintFirstArr(arr1, arr2);
                return;
            }
        }
    }
}
