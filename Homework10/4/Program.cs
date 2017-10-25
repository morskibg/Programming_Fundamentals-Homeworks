using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static int CalcSumFromTwoStrings(string str1, string str2)
        {
            int biggerLength = Math.Max(str1.Length, str2.Length);
            int sum = 0;
            for(int i = 0; i < biggerLength; ++i)
            {
                int multStr1 = 1;
                int multStr2 = 1;
                if(i < str1.Length)
                {
                    multStr1 = (int)str1[i];
                }
                if(i < str2.Length)
                {
                    multStr2 = (int)str2[i];
                }
                sum += multStr1 * multStr2;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split().ToArray();
            string str1 = tokens[0];
            string str2 = tokens[1];
            int result = CalcSumFromTwoStrings(str1, str2);
            Console.WriteLine(result);

        }
    }
}
