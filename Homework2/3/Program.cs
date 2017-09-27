using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static string GetHall(int people, out decimal totalPeice)
        {
            string hall = "";
            if (people <= 50)
            {
                hall = "Small Hall";
                totalPeice = 2500;
            }
            else if (people > 50 && people <= 100)
            {
                hall = "Terrace";
                totalPeice = 5000;
            }
            else if (people > 100 && people <= 120)
            {
                hall = "Great Hall";
                totalPeice = 7500;
            }
            else
            {
                hall = "We do not have an appropriate hall.";
                totalPeice = -1;
            }
            return hall;
        }

        static double GetDiscount(string package, out decimal price)
        {
            if (package == "Normal")
            {
                price = 500;
                return 0.95;
            }
            else if (package == "Gold")
            {
                price = 750;
                return 0.9;
            }
            else
            {
                price = 1000;
                return 0.85;
            }
        }
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal hallPrice = 0;
            decimal packagePrice = 0;
            string hall = GetHall(people, out hallPrice);
            double discout =  GetDiscount(package, out packagePrice);
            decimal totalPrice = (hallPrice + packagePrice) * (decimal)discout;
            decimal pricePerPerson = totalPrice / people;
            if (hallPrice == -1)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hall}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            
           
        }
    }
}
