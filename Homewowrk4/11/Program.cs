using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11
{
    
    class Program
    {
        static double FigureAreaCalculator(string figure, double commonParam)
        {
            if (figure == "triangle" || figure == "rectangle")
            {
                double secondParam = double.Parse(Console.ReadLine());
                if (figure == "triangle")
                {
                    return commonParam * secondParam / 2;
                }
                return commonParam * secondParam;
            }
            if (figure == "square")
            {
                return commonParam * commonParam;
            }
            return Math.PI * commonParam * commonParam;
        }
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double commonParam = double.Parse(Console.ReadLine());
            double answer = FigureAreaCalculator(figure, commonParam);
            Console.Write(Math.Round(answer,2));

        }
    }
}
