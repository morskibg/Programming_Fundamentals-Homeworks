using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method1
{
    class Program
    {
        static bool IsPrime(long num)
        {
            int upperBond = (int)Math.Sqrt((double)num);
            if (num == 0 || num == 1)
            {
                return false;
            }
            for (int i = 2; i <= upperBond; ++i)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(n));

        }
    }
}
