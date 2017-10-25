using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            int baseToConvert = int.Parse(tokens[0]);
            BigInteger num = BigInteger.Parse(tokens[1]);
            StringBuilder convertedNum = new StringBuilder();
            while (num != 0)
            {
                convertedNum.Append(num % baseToConvert);
                num /= baseToConvert;
            }
            for (int i = convertedNum.Length - 1; i >= 0; --i)
            {
                Console.Write(convertedNum[i]);
            }
            Console.WriteLine();
        }
    }
}
