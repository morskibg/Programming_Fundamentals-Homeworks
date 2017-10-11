using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] bombRaw = Console.ReadLine().Split(' ').ToArray();
            int bomb = int.Parse(bombRaw[0]);
           
            int bombPower = int.Parse(bombRaw[1]);
            for(int i = 0; i < nums.Count; ++i)
            {
                if(nums[i] == bomb)
                {
                    int startIdx = i - bombPower;
                    int endIdx = i + bombPower;
                    int fullBlastInterval = 2 * bombPower + 1;
                    if(startIdx >= 0 && endIdx <= nums.Count - 1)
                    {
                        nums.RemoveRange(startIdx, fullBlastInterval);
                    }
                    else if(startIdx >= 0 && endIdx > nums.Count - 1)
                    {
                        nums = nums.Take(startIdx).ToList();
                    }
                    else if(startIdx < 0 && endIdx <= nums.Count - 1)
                    {
                        nums = nums.Skip(endIdx + 1).ToList();
                    }
                    else
                    {
                        nums.Clear();
                    }
                    i = 0;
                }
            }
            decimal sum = nums.Sum();
            Console.WriteLine(sum);

        }
    }
}
