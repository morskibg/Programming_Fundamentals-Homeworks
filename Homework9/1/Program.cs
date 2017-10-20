using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            Dictionary<int, int> maxSeqCounter = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                if (!maxSeqCounter.ContainsKey(num))
                {
                    maxSeqCounter[num] = 0;
                }
                maxSeqCounter[num]++;
            }
            foreach (var kvp in maxSeqCounter.OrderByDescending(kvp => kvp.Value))
            {
                Console.WriteLine(kvp.Key);
                break;
            }
        }
    }
}
