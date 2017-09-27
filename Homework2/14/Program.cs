using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            char begin = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            char forbidden = char.Parse(Console.ReadLine());
            for (char ch1 = begin; ch1 <= end; ++ch1)
            {
                for (char ch2 = begin; ch2 <= end; ++ch2)
                {
                    for (char ch3 = begin; ch3 <= end; ++ch3)
                    {
                        string res = ch1.ToString() + ch2.ToString() + ch3.ToString();
                        if (res.Contains(forbidden.ToString()))
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write(res + " ");
                        }
                    }
                }
            }
        }
    }
}
