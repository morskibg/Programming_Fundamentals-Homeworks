using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            long totalNumberOfPictures = long.Parse(Console.ReadLine());
            long filteringTimePerPicture = long.Parse(Console.ReadLine());
            int percentageGoonPictures = int.Parse(Console.ReadLine());
            long uploadTimePerPicture = long.Parse(Console.ReadLine());

            long goodPictures = (long)(Math.Ceiling((double)totalNumberOfPictures * percentageGoonPictures / 100));
            decimal filteringTime = totalNumberOfPictures * filteringTimePerPicture;
            decimal uploadTime = goodPictures * uploadTimePerPicture;
            decimal totalTime = filteringTime + uploadTime;

            TimeSpan timeSpan = TimeSpan.FromSeconds((long)totalTime);
            string timeToPrint = timeSpan.ToString(@"d\:hh\:mm\:ss");

            Console.WriteLine(timeToPrint);
        }
    }
}
