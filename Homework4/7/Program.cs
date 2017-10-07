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
            int[] Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int upCounter = 0;
            int startIdx = 0;
            int currIdx = 0;
            int endIdx = Arr.Length - 1; 
            int tempCounter = 1;
            for (int i = Arr.Length - 1; i >= 1; --i)
            {
                if (Arr[i] > Arr[i - 1])
                {
                    ++tempCounter;
                    currIdx = i - 1;
                }
                else
                {
                    if (tempCounter >= upCounter)
                    {
                        upCounter = tempCounter;
                        startIdx = currIdx;
                    }
                    tempCounter = 1;
                }
               
            }
            if (tempCounter >= upCounter)
            {
                upCounter = tempCounter;
                startIdx = currIdx;
            }
            for (int i = startIdx; i < startIdx + upCounter; ++i)
            {
                Console.Write(Arr[i] + " ");
            }
        }
    }
}
