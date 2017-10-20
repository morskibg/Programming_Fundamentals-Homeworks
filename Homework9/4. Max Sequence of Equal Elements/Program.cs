using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            List<List<int>> maxSeq = new List<List<int>>();
            maxSeq.Add(new List<int>{nums[0]});
            
            for (int i = 1; i < nums.Length; i++)
            {
                if (maxSeq.Last().Last() != nums[i])
                {
                    maxSeq.Add(new List<int>());
                }
                maxSeq.Last().Add(nums[i]);
            }
            foreach (var maxList in maxSeq.OrderByDescending(x => x.Count))
            {
                Console.WriteLine($"{string.Join(" ", maxList)}");
                return;
            }
        }
    }
}
