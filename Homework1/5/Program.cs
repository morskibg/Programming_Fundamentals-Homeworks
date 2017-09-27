using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double currHelth = double.Parse(Console.ReadLine());
            double maxHelth = double.Parse(Console.ReadLine());
            double currEnergy = double.Parse(Console.ReadLine());
            double maxEnergy = double.Parse(Console.ReadLine());
            Console.WriteLine("Name: {0}",name);
            Console.WriteLine("Health: |{0}{1}|", new string('|', (int)currHelth), new string('.', (int)(maxHelth - currHelth)));
            Console.WriteLine("Energy: |{0}{1}|", new string('|', (int)currEnergy), new string('.', (int)(maxEnergy - currEnergy)));
        }
    }
}
