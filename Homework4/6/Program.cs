using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int bestStartIdx = 0;
            int bestLen = 0;
            int bestNum = initArr[0];
            int tempLen = 1;
            int tempIdx = 0;
            for (int i = 1; i < initArr.Length; i++)
            {
                if (bestNum == initArr[i])
                {
                    ++tempLen;
                }
                else
                {
                    if (tempLen > bestLen)
                    {
                        bestLen = tempLen;
                        bestStartIdx = tempIdx;
                    }
                    tempLen = 1;
                    tempIdx = i;
                    bestNum = initArr[i];
                }
            }
            if (tempLen > bestLen)
            {
                bestLen = tempLen;
                bestStartIdx = tempIdx;
            }
            for (int i = bestStartIdx; i < bestStartIdx + bestLen; i++)
            {
                Console.Write(initArr[i] + " ");
            }
        }
    }
}
