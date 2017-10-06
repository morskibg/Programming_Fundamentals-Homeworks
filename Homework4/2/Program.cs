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
            int[] initArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());
            
            int col = initArr.Length;
            int row = rotations;
            int[,] matrix = new int[row + 1, col];

            for (int i = 0; i < row + 1; ++i)
            {
                for(int j = 0; j < col; ++j)
                {
                    if (i == 0)
                    {
                        matrix[i, j] = initArr[j];
                    }
                    else
                    {
                        int k = j + 1;
                        matrix[i, k % col] = matrix[i - 1, j];
                    }
                }
                
            }
            for (int i = 0; i < col; ++i)
            {
                initArr[i] = 0;
                for (int j = 1; j < row + 1; ++j)
                {
                    initArr[i] += matrix[j, i];
                }
            }
            Console.WriteLine($"{string.Join(" ", initArr)}");
        }
    }
}
