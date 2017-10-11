using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 2;
            List<int> nums = new List<int> { 2, 3, 5, 9, 8, 7, 6, 5, 1 };
            for (int i = 0; i < t; ++i)
            {
                int m = nums[i];
                nums.Add(m);
            }
            nums.RemoveRange(0, t);
            Console.WriteLine(string.Join(" ", nums));
        }
       
    } 
}
