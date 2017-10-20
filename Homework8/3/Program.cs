using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static bool Intersect(Circle circ1, Circle circ2)
        {
            double a = Math.Pow((circ1.Center.X - circ2.Center.X), 2);
            double b = Math.Pow((circ1.Center.Y - circ2.Center.Y), 2);
            double distanceBetweenCenters = Math.Sqrt((a + b));
            if (distanceBetweenCenters <= circ1.Radius + circ2.Radius)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            
            Circle[] circlesData = new Circle[2];
            for (int i = 0; i < 2; ++i)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
                circlesData[i] = new Circle(tokens[0], tokens[1], tokens[2]);
            }
            if (Intersect(circlesData[0], circlesData[1]))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
           
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }

        public Circle(int x, int y, int rad)
        {
            this.Center = new Point(x, y);
            this.Radius = rad;
        }
    }
}
