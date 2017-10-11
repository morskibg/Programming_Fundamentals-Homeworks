using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while(command[0] != "print")
            {
                if(command[0] == "add")
                {
                    int idx = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    nums.Insert(idx, element);
                }
                else if(command[0] == "addMany")
                {
                    int idx = int.Parse(command[1]);
                    nums.InsertRange(idx, command.Skip(2).Select(int.Parse).ToArray());
                }
                else if(command[0] == "contains")
                {
                    int element = int.Parse(command[1]);
                    Console.WriteLine(nums.Find(x => x == element));
                }
                else if (command[0] == "remove")
                {
                    int idx = int.Parse(command[1]);
                    nums.RemoveAt(idx);
                }
                else if (command[0] == "shift")
                {
                    int position = int.Parse(command[1]);
                    
                }
            } 
        }
    }
}
