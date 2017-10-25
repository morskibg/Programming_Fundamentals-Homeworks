using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static string MultiplyBigNumByDigit(string num, int multiplier)
        {
            List<string> result = new List<string>();
            int carry = 0;
            char[] chars = num.ToCharArray();
            Array.Reverse(chars);
            string reversedNum = new string(chars);
            for (int i = 0; i < num.Length; ++i)
            {               
                int a = (int)char.GetNumericValue(reversedNum[i]);
                int c = a * multiplier + carry;
                if(c > 9)
                {
                    int digit = c % 10;
                    result.Add(digit.ToString());
                    carry = c / 10;
                }
                else
                {
                    result.Add(c.ToString());
                    carry = 0;
                }
            }
            if(carry > 0)
            {
                result.Add(carry.ToString());
            }
            result.Reverse();
            return string.Join("", result);
        }
       
        static void Main(string[] args)
        {
            string Num = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }
            Console.WriteLine(MultiplyBigNumByDigit(Num, multiplier));

        }
    }
}
