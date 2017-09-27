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
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Math.Max(a, b) - Math.Min(a, b) < 5)
            {
                Console.WriteLine("No");
            }
            else
            {
                int begin = Math.Min(a, b);
                int end = Math.Max(a, b);
                for (int n1 = begin; n1 <= end; ++n1)
                {
                    for (int n2 = begin; n2 <= end; ++n2)
                    {
                        for (int n3 = begin; n3 <= end; ++n3)
                        {
                            for (int n4 = begin; n4 <= end; ++n4)
                            {
                                for (int n5 = begin; n5 <= end; ++n5)
                                {
                                    if (begin <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= end)
                                    {
                                        string res =
                                            n1.ToString() + " " + n2.ToString() + " " + n3.ToString() + " " +
                                            n4.ToString() + " " +
                                            n5.ToString();
                                        Console.WriteLine(res);
                                    }

                                }
                            }
                        }
                    }
                }

            }
        }
    }
}