using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            for (int i = 0; i < n; ++i)
            {
                string input = Console.ReadLine();
                input = input.ToLower();
                if (input == "cheese")
                {
                    totalCalories += 500;
                }
                else if (input == "tomato sauce")
                {
                    totalCalories += 150;
                }
                else if (input == "salami")
                {
                    totalCalories += 600;
                }
                else if (input == "pepper")
                {
                    totalCalories += 50;
                }
            }
            Console.WriteLine($"Total calories: {totalCalories}");
        }
    }
}
