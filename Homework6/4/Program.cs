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
            int maxNum = nums.Max();
            List<int> currLIS = new List<int>();
            int maxLisCount = -1;
            List<int> LIS = new List<int>();
            
            for (int i = 0; i < nums.Count - 1; ++i)
            {
                bool isFinished = false;
                int k = i + 1;
                while (!isFinished)
                {
                    currLIS.Add(nums[i]);
                    
                    for (; k < nums.Count; ++k)
                    {
                        if(currLIS.Last() < nums[k])
                        {
                            currLIS.Add(nums[k]);
                        }
                    }
                     int lastUsedIdx = nums.IndexOf(currLIS.Last());
                    int[] remainingNums = new int[nums.Count - lastUsedIdx - 1];
                    nums.CopyTo(lastUsedIdx + 1, remainingNums, 0, nums.Count - lastUsedIdx - 1);
                    int remainingMax = remainingNums.Max();
                    if (nums[i] >= remainingMax)
                    {
                        isFinished = true;
                    }
                    ++k;
                    if(maxLisCount < currLIS.Count)
                    {
                        maxLisCount = currLIS.Count;
                        if(LIS.Count != 0)
                        {
                            LIS.Clear();
                        }
                        LIS.AddRange(currLIS);
                    }
                    currLIS.Clear();
                }
            }
            Console.WriteLine(string.Join(" ",LIS));
        }
    }
}
