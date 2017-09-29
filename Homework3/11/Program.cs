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
            int distInMetre = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            float totalSeconds = (float)hours * 60 * 60 + (float)minute * 60 + seconds;
            float speedMetrePerSecond = distInMetre / totalSeconds;
            Console.WriteLine(speedMetrePerSecond);
            Console.WriteLine(speedMetrePerSecond * 3600 / 1000);
            Console.WriteLine(speedMetrePerSecond * 3600 / 1609);



        }
    }
}
