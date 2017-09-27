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
            string profesion = Console.ReadLine();
            int qty = int.Parse(Console.ReadLine());
            double amount = 0;
            string result = "";
            if (profesion == "Athlete")
            {
                result = "Water";
                amount = qty * 0.7;
            }
            else if (profesion == "Businessman" || profesion == "Businesswoman")
            {
                result = "Coffee";
                amount = qty * 1;
            }
            else if (profesion == "SoftUni Student")
            {
                result = "Beer";
                amount = qty * 1.7;
            }
            else
            {
                result = "Tea";
                amount = qty * 1.2;
            }
            Console.WriteLine($"The {profesion} has to pay {amount:f2}.");
        }
    }
}
