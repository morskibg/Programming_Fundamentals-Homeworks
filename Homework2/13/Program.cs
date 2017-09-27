using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = M; i >= N; --i)
            {
                for (int j = M; j >= N; --j)
                {
                    ++counter;
                    int sum = i + j;
                    if (sum == magicNum)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNum}");
                        return;
                    }
                }

            }
            Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
        }
    }
}
