using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "Odd" && input != "Even")
            {
                string[] rawData = input.Split(' ').ToArray();
                if (rawData[0] == "Delete")
                {
                    int toRemove = int.Parse(rawData[1]);
                    nums = nums.Where(x => x != toRemove).ToList();
                }
                else if (rawData[0] == "Insert")
                {
                    int toInsert = int.Parse(rawData[1]);
                    int position = int.Parse(rawData[2]);
                    nums.Insert(position, toInsert);
                }
                input = Console.ReadLine();
            }
            if (input == "Odd")
            {
                Console.WriteLine(string.Join(" ", nums
                    .Where(x => x % 2 != 0)
                    .ToList()));
            }
            else
            {
                Console.WriteLine(string.Join(" ", nums
                    .Where(x => x % 2 == 0)
                    .ToList()));
            }
        }
    }
}
