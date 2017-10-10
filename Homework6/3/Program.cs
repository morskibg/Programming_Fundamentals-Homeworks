using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] controlNums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            nums = nums.Take(controlNums[0]).ToList();
            nums = nums.Skip(controlNums[1]).ToList();
            if (nums.Contains(controlNums[2]))
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }
    }
}
