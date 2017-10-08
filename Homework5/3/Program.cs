using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int oneQuarter = initArr.Length / 4;
            int[] upperLeft = new int[oneQuarter];
            for (int i = 0; i < oneQuarter; ++i)
            {
                upperLeft[i] = initArr[i];
            }
            Array.Reverse(upperLeft);
            int[] upperRight = new int[oneQuarter];
            for (int i = 3 * oneQuarter; i < initArr.Length; ++i)
            {
                upperRight[i - 3 * oneQuarter] = initArr[i];
            }
            Array.Reverse(upperRight);
            int[] lowerArr = new int[2 * oneQuarter];
            for (int i = 0; i < 2 * oneQuarter; ++i)
            {
                lowerArr[i] = initArr[i + oneQuarter];
            }
            for (int i = 0; i < oneQuarter; ++i)
            {
                lowerArr[i] += upperLeft[i];
                lowerArr[i + oneQuarter] += upperRight[i];
            }
            Console.WriteLine($"{string.Join(" ", lowerArr)}");

        }
    }
}
