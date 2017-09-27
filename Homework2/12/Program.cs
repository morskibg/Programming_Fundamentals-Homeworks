using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int maxSumBoundary = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int counter = 0;
            for (int i = N; i >= 1; --i)
            {
                for (int j = 1; j <= M; ++j)
                {
                    totalSum += i * j * 3;
                    counter++;
                    if (totalSum >= maxSumBoundary)
                    {

                        Console.WriteLine($"{counter} combinations");
                        Console.WriteLine($"Sum: {totalSum} >= {maxSumBoundary}");
                        return;
                    }

                }

            }
            Console.WriteLine($"{counter} combinations");
            Console.WriteLine($"Sum: {totalSum}");

        }
    }
}
