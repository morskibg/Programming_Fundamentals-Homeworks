using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static string ReversePrint(decimal num)
        {
            return num.ToString();
        }
        static void Main(string[] args)
        {
            decimal inputNum = decimal.Parse(Console.ReadLine());
            string res = ReversePrint(inputNum);
            for (int i = res.Length - 1; i >= 0; --i)
            {
                Console.Write(res[i]);
            }


        }
    }
}
