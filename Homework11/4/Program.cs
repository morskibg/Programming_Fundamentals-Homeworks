using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<double, string>> cities = new Dictionary<string, Dictionary<double, string>>();
            string line = Console.ReadLine();
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+(?=\|))";
            
            while (line != "end")
            {
                Match matchedData = Regex.Match(line, pattern);
                if (matchedData.Groups.Count == 4)
                {
                    string city = matchedData.Groups[1].ToString();
                    double temperature = double.Parse(matchedData.Groups[2].ToString());
                    string weather = matchedData.Groups[3].ToString();
                    cities[city] = new Dictionary<double, string>
                    {
                        {temperature, weather}
                    };
                    cities[city][temperature] = weather;
                }
                line = Console.ReadLine();
            }
            foreach (var city in cities.OrderBy(x => x.Value.First().Key))
            {
                Console.WriteLine($"{city.Key} => {city.Value.First().Key} => {city.Value.First().Value}");
            }
        }
    }
}
