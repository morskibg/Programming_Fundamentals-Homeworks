using System;
using System.Collections.Generic;
using System.IO;
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
            
            
            string[] input = File.ReadAllLines("input.txt");
            int idx = 0;
            string lastMetal = "";
            while (input[idx] != "stop")
            {
                long parsed;
                if (!long.TryParse(input[idx], out parsed))
                {
                    lastMetal = input[idx];
                    if (!minerData.ContainsKey(lastMetal))
                    {
                        minerData[lastMetal] = 0;
                    }
                }
                else
                {
                    minerData[lastMetal] += parsed;
                }
                ++idx;
            }
            File.WriteAllText("output.txt","");
            foreach (var metal in minerData)
            {
                
                File.AppendAllText("output.txt", $"{metal.Key.ToString()} -> {metal.Value.ToString()}" + Environment.NewLine);
            }
        }
    }
}
