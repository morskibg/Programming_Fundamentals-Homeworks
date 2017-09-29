using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string hex = Convert.ToString(n, 16);
            hex = hex.ToUpper();
            Console.WriteLine(hex);
            Console.WriteLine(Convert.ToString(n, 2));
        }
    }
}
