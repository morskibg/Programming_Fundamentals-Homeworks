using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void PrintName(string nameToPrint)
        {
            Console.WriteLine($"Hello, {nameToPrint}!");
        }
        static void Main(string[] args)
        {
            PrintName(Console.ReadLine());
        }
    }
}