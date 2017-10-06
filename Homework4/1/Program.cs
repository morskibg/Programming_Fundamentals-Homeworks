using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
            int startCount = 0;
            while (startCount < Math.Min(arr1.Length, arr2.Length))
            {
                if (arr1[startCount] != arr2[startCount])
                {
                    break;
                }
                ++startCount;
            }
            int endCount = 0;
            while (endCount < Math.Min(arr1.Length, arr2.Length))
            {
                if (arr1[arr1.Length - 1 - endCount] != arr2[arr2.Length - 1 -endCount])
                {
                    break;
                }
                ++endCount;
            }
            Console.WriteLine("{0}",startCount >= endCount ? startCount : endCount);
        }
    }
}
