using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            string result = "";
            if (profesion == "Athlete")
            {
                result = "Water";
            }
            else if (profesion == "Businessman" || profesion == "Businesswoman" )
            {
                result = "Coffee";
            }
            else if (profesion == "SoftUni Student")
            {
                result = "Beer";
            }
            else
            {
                result = "Tea";
            }
            Console.WriteLine(result);
        }
    }
}
