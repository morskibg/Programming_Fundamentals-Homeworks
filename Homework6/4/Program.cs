using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> LIS = new List<int>();
            int start = 0;
            int max = 0;
            int prevLength = 0;
            while (start < nums.Count)
            {
                int currMaxNum = nums[start];
                for (int i = start; i < nums.Count - 1; ++i)
                {
                    
                    if (nums[i] < nums[i + 1] && currMaxNum < nums[i + 1])
                    {
                        LIS.Add(nums[i]);
                        currMaxNum = nums[i + 1];
                    }
                }
                if (LIS.Count > prevLength)
                {
                    max = start;
                    prevLength = LIS.Count;
                }
                LIS.Clear();
                ++start;
            }
            int t = 0;
        }
    }
}
