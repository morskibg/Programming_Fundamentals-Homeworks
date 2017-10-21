using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = File.ReadAllText("input.txt").Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
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
            int number = 0;
            int occurrence = 0;
            foreach (var kvp in maxSeqCounter.OrderByDescending(kvp => kvp.Value))
            {
                number = kvp.Key;
                occurrence = kvp.Value;
                break;
            }
            string result = $"The number {number} is the most frequent leftmost (occurs {occurrence} times.)";
            File.WriteAllText("output.txt", result);
        }
    }
}
