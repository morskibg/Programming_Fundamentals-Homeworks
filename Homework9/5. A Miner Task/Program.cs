using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> minerData = new Dictionary<string, long>();
            
            
            string input = Console.ReadLine();
            string lastMetal = "";
            while (input != "stop")
            {
                long parsed;
                if (!long.TryParse(input, out parsed))
                {
                    lastMetal = input;
                    if (!minerData.ContainsKey(lastMetal))
                    {
                        minerData[lastMetal] = 0;
                    }
                }
                else
                {
                    minerData[lastMetal] += parsed;
                }
                input = Console.ReadLine();
            }
            foreach (var metal in minerData)
            {
                Console.WriteLine($"{metal.Key} -> {metal.Value}");
            }
        }
    }
}
