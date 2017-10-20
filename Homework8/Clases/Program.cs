using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime
                .ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);


            if (startDate > endDate)
            {
                DateTime temp = startDate;
                startDate = endDate;
                endDate = temp;
            }

            int inputYear = endDate.Year;
            int workDays = 0;
            DateTime[] offDays = new DateTime[]
            {
                new DateTime(inputYear, 1, 1),
                new DateTime(inputYear, 3, 3),
                new DateTime(inputYear, 5, 1),
                new DateTime(inputYear, 5, 6),
                new DateTime(inputYear, 5, 24),
                new DateTime(inputYear, 9, 6),
                new DateTime(inputYear, 9, 22),
                new DateTime(inputYear, 11, 1),
                new DateTime(inputYear, 12, 24),
                new DateTime(inputYear, 12, 25),
                new DateTime(inputYear, 12, 26),

            };
            DateTime currDay = startDate;
            
            while (currDay <= endDate)
            {
                bool isHolyDay = offDays
                    .Any(x => x.Month == currDay.Month && x.Day == currDay.Day);
                
                if (isHolyDay || 
                    currDay.DayOfWeek == DayOfWeek.Saturday ||
                    currDay.DayOfWeek == DayOfWeek.Sunday)
                {
                    currDay = currDay.AddDays(1);
                    
                    continue;
                }
                currDay = currDay.AddDays(1);
                ++workDays;
            }
            Console.WriteLine(workDays);
        }
    }
}
