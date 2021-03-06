﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = File.ReadAllText("input.txt").Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            bool isFounded = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                if (i > 0)
                {
                    leftSum = nums.Where((x, idx) => idx >= 0 && idx < i).Sum();
                }
                if (i < nums.Length - 1)
                {
                    rightSum = nums.Where((x, idx) => idx > i  && idx < nums.Length).Sum();
                }
                if (leftSum == rightSum)
                {
                    File.WriteAllText("output.txt", i.ToString());
                    isFounded = true;
                }
            }
            if (!isFounded)
            {
                File.WriteAllText("output.txt", "no");
            }
        }
    }
}
