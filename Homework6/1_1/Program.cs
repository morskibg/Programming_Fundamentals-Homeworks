using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Dictionary<int, int> myDict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                if (!myDict.ContainsKey(nums[i]))
                {
                    myDict[nums[i]] = 0;
                }
                myDict[nums[i]]++;
            }
            int maxOccurance = myDict.Values.Max();
            int maxKey = myDict.First(kvp => kvp.Value == maxOccurance).Key;
            for (int i = 0; i < maxOccurance; ++i)
            {
                Console.Write(maxKey + " ");
            }
        }
    }
}
