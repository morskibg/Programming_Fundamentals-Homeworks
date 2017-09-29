using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            int centures = int.Parse(Console.ReadLine());
            int years = centures * 100;
            int days = (int)( years * 365.2422);
            decimal hours = days * 24;
            decimal minutes = hours * 60;
            decimal seconds = minutes * 60;
            decimal miliseconds = seconds * 1000;
            decimal microseconds = miliseconds * 1000;
            decimal nanoseconds = microseconds * 1000;
            Console.WriteLine($"{centures} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes =" +
                              $" {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds } nanoseconds");
        }
    }
}
