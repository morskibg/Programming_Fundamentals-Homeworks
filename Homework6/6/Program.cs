using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static decimal ReverseDigits(string input)
        {
            string res = "";
            for(int i = input.Length - 1; i >= 0; --i)
            {
                res += input[i];
            }
            decimal num = decimal.Parse(res);
            return num;
        }
        static void Main(string[] args)
        {
            string[] rawData = Console.ReadLine().Split(' ').ToArray();
            decimal sum = 0;
            for(int i = 0; i < rawData.Length; ++i)
            {
                sum += ReverseDigits(rawData[i]);
            }
            Console.WriteLine(sum);
        }
    }
}
