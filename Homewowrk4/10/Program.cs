using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static double CubeCalculator(double side, string command)
        {
            if (command == "face")
            {
                return Math.Sqrt(2 * Math.Pow(side, 2));
            }
            else if (command == "space")
            {
                return Math.Sqrt(3 * Math.Pow(side, 2));
            }
            else if (command == "volume")
            {
                return Math.Pow(side, 3);
            }
            else
            {
                return 6 * Math.Pow(side, 2);
            }
        }
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Console.WriteLine(Math.Round(CubeCalculator(side, command), 2));

        }
    }
}
