using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int leftSum = 0;
            int rightSum = 0;
            bool isFounded = false;
            for (int i = 0; i < Arr.Length; i++)
            {
                
                if (i == 0)
                {
                    leftSum = 0;
                }
                else if (i == Arr.Length - 1)
                {
                    rightSum = 0;
                }

                for (int j = 0; j < i; ++j)
                {
                    leftSum += Arr[j];
                }
                for (int j = i + 1; j < Arr.Length; ++j)
                {
                    rightSum += Arr[j];
                }

                if (leftSum == rightSum)
                {
                    Console.Write(i + " ");
                    isFounded = true;
                }
                leftSum = 0;
                rightSum = 0;
            }
           
            if(!isFounded)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
