using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18
{
    class Program
    {
        //(sbyte < byte < short < ushort < int < uint < long).
        static void Main(string[] args)
        {
            decimal N = decimal.Parse(Console.ReadLine());
            List<string> fittableDataTypes = new List<string>();
            if (N <= sbyte.MaxValue && N >= sbyte.MinValue)
            {
                fittableDataTypes.Add("sbyte");
            }
            if (N <= byte.MaxValue && N >= byte.MinValue)
            {
                fittableDataTypes.Add("byte");
            }
            if (N <= short.MaxValue && N >= short.MinValue)
            {
                fittableDataTypes.Add("short");
            }
            if (N <= ushort.MaxValue && N >= ushort.MinValue)
            {
                fittableDataTypes.Add("ushort");
            }
            if (N <= int.MaxValue && N >= int.MinValue)
            {
                fittableDataTypes.Add("int");
            }
            if (N <= uint.MaxValue && N >= uint.MinValue)
            {
                fittableDataTypes.Add("uint");
            }
            if (N <= long.MaxValue && N >= long.MinValue)
            {
                fittableDataTypes.Add("long");
            }
            if (fittableDataTypes.Count == 0)
            {
                Console.WriteLine($"{N} can't fit in any type");
            }
            else
            {
                Console.WriteLine($"{N} can fit in:");
                foreach (var currDataType in fittableDataTypes)
                {
                    Console.WriteLine($" * {currDataType}");
                }

            }
        }
    }
}
