﻿using System;
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
            while (command[0] != "print")
            {
                if (command[0] == "add")
                {
                    int idx = int.Parse(command[1]);
                    int element = int.Parse(command[2]);
                    nums.Insert(idx, element);
                }
                else if (command[0] == "addMany")
                {
                    int idx = int.Parse(command[1]);
                    nums.InsertRange(idx, command.Skip(2).Select(int.Parse).ToArray());
                }
                else if (command[0] == "contains")
                {
                    int element = int.Parse(command[1]);
                    Console.WriteLine(nums.IndexOf(element));
                }
                else if (command[0] == "remove")
                {
                    int idx = int.Parse(command[1]);
                    nums.RemoveAt(idx);
                }
                else if (command[0] == "shift")
                {
                    int positions = int.Parse(command[1]);
                    for (int i = 0; i < positions; i++)
                    {
                        int temp = nums[i];
                        nums.Add(temp);
                    }
                    nums.RemoveRange(0, positions);
                }
                else if (command[0] == "sumPairs")
                {
                    List<int> tempList = new List<int>();
                    int endBoundary = nums.Count;
                    int lastElement = nums.Last();
                    bool isOddCount = false;
                    if (nums.Count % 2 != 0)
                    {
                        --endBoundary;
                        isOddCount = true;
                    }
                    for (int i = 1; i <= endBoundary; i++)
                    {
                        if (i % 2 != 0)
                        {
                            tempList.Add(nums[i - 1] + nums[i]);
                        }
                    }
                    nums.Clear();
                    nums.AddRange(tempList);
                    if (isOddCount)
                    {
                        nums.Add(lastElement);
                    }
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine($"[{string.Join(", ", nums)}]");
        }
    }
}
