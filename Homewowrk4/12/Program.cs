using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static bool isSymmetric(long num)
        {
            if (num - 10 < 0)
            {
                return true;
            }
            string stringNum = num.ToString();
            int size = stringNum.Length;
            for (int i = 0; i <= size / 2; i++)
            {
                if (stringNum[i] != stringNum[size - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool isSumOfDigitsDivBy7(long num)
        {
            if (num == 0)
            {
                return false;
            }
            long sum = 0;
            while(num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        static bool hasAtLeastOneEven(long num)
        {
            while (num != 0)
            {
                if ((num % 10) % 2 == 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
        static void Main(string[] args)
        {
            long endRange = long.Parse(Console.ReadLine());
            List<long> specialNums = new List<long>();
            for (int i = 0; i <= endRange; ++i)
            {
                if (isSymmetric(i) && isSumOfDigitsDivBy7(i) && hasAtLeastOneEven(i))
                {
                    specialNums.Add(i);
                }
            }
            foreach (var item in specialNums)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
