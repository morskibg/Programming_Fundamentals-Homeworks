using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void GetPrices(string month, int nights, out double[] prices)
        {
            prices = new double[3];
            double discout = 1;
            if (month == "May" || month == "October")
            {
                if (nights > 7)
                {
                    discout = 0.95;
                }
                prices[0] = 50 * nights * discout - (nights > 7 && month == "October" ? 50 * discout : 0);
                prices[1] = 65 * nights;
                prices[2] = 75 * nights;
            }
            else if (month == "June" || month == "September")
            {
                if (nights > 14)
                {
                    discout = 0.9;
                }
                prices[0] = 60 * nights - (nights > 7 && month == "September" ? 60 * discout : 0); ;
                prices[1] = 72 * nights * discout;
                prices[2] = 82 * nights;
            }
            else
            {
                if (nights > 14)
                {
                    discout = 0.85;
                }
                prices[0] = 68 * nights;
                prices[1] = 77 * nights;
                prices[2] = 89 * nights * discout;
            }
        }

        
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double discount = 0;
            
            double[] pricePerRoomType = new double[3];
            GetPrices(month, nights, out pricePerRoomType);
            Console.WriteLine($"Studio: {pricePerRoomType[0]:f2} lv.");
            Console.WriteLine($"Double: {pricePerRoomType[1]:f2} lv.");
            Console.WriteLine($"Suite: {pricePerRoomType[2]:f2} lv.");

        }
    }
}
