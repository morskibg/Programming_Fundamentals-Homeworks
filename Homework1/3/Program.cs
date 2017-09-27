using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    
    class Program
    {
        const double mileToKm = 1.60934;
        static void Main(string[] args)
        {
            Console.WriteLine("{0:f2}", double.Parse(Console.ReadLine()) * mileToKm);
        }
    }
}
