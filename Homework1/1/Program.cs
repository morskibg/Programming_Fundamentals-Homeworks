using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    
    class Program
    {
        const int digits = 4;
        static void Main(string[] args)
        {
            string[] nums = new string[digits];
            for(int i = 0; i < digits; ++i)
            {
                nums[i] = Console.ReadLine().PadLeft(digits, '0');

            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
