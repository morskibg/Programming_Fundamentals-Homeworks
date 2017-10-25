using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            int fromBase = int.Parse(tokens[0]);
           
            BigInteger num = BigInteger.Parse(tokens[1]);
            if (fromBase == 10)
            {
                Console.WriteLine(num);
                return;
            }
            List<int> inputBaseMulti = new List<int>();

            BigInteger temp = num;
            while (temp != 0)
            {
                inputBaseMulti.Add((int)(temp % 10));
                temp /= 10;
            }
            BigInteger converted = 0;
            for (int i = inputBaseMulti.Count - 1; i >= 0; i--)
            {
                converted += inputBaseMulti[i] * BigInteger.Pow((BigInteger)fromBase, i);
            }
            Console.WriteLine(converted);
        }
    }
}
