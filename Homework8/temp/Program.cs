using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Coffee_Supplies
{
    class Program
    {
        public class Coffe
        {
            public string CofeeType { get; set; }
            public int CoffeMaxCount { get; set; }
            public List<string> PeopleDrinkingThisCoffe { get; set; }
            public List<int> DrinkingCoffesForWeek { get; set; }
            public int LeftCoffe { get; set; }
        }
        static void Main(string[] args)
        {
            List<Coffe> coffeList = new List<Coffe>();

            string[] inputKeys = Console.ReadLine().Split();
            string firstKey = inputKeys[0].Trim();
            string secondKey = inputKeys[1].Trim();

            while (true)
            {
                var createCoffe = new Coffe();
                string inputCoffe = Console.ReadLine();
                if (inputCoffe == "end of info")
                {
                    break;
                }
                if (inputCoffe.Contains(firstKey))
                {
                    string[] tokens =
                        inputCoffe.Split(new string[] { $"{firstKey}" }, StringSplitOptions.RemoveEmptyEntries);
                    string peopleDrinkingThisCoffe = tokens[0].Trim();
                    string coffeType = tokens[1].Trim();

                    foreach (var coffe in coffeList)
                    {
                        if (coffe.CofeeType.Contains(coffeType))
                        {
                            coffe.PeopleDrinkingThisCoffe.Add(peopleDrinkingThisCoffe);
                            break;
                        }
                    }
                    var result = coffeList.FindIndex(a => a.CofeeType == coffeType);
                    if (result == -1)
                    {
                        createCoffe.CofeeType = coffeType;
                        createCoffe.PeopleDrinkingThisCoffe = new List<string>();
                        createCoffe.DrinkingCoffesForWeek = new List<int>();
                        createCoffe.PeopleDrinkingThisCoffe.Add(peopleDrinkingThisCoffe);

                        coffeList.Add(createCoffe);
                    }
                }
                else
                {
                    string[] tokens = inputCoffe.Split(new string[] { $"{secondKey}" },
                        StringSplitOptions.RemoveEmptyEntries);

                    string coffeType = tokens[0].Trim();
                    int coffeMaxCount = int.Parse(tokens[1].Trim());

                    int indexOfCurrentCoffe = coffeList.FindIndex(a => a.CofeeType == coffeType);

                    coffeList[indexOfCurrentCoffe].CoffeMaxCount += coffeMaxCount;
                    coffeList[indexOfCurrentCoffe].LeftCoffe += coffeMaxCount;
                }
            }
            foreach (var zeroCoffe in coffeList)
            {
                if (zeroCoffe.LeftCoffe == 0)
                {
                    Console.WriteLine($"Out of {zeroCoffe.CofeeType}");
                }
            }

            while (true)
            {
                string drinkingCoffeThisWeek = Console.ReadLine();
                if (drinkingCoffeThisWeek == "end of week")
                {
                    break;
                }

                string[] weeksCoffes = drinkingCoffeThisWeek.Split();
                string peopleDrinkingCoffe = weeksCoffes[0].Trim();
                int coffeCount = int.Parse(weeksCoffes[1].Trim());

                foreach (var item in coffeList)
                {
                    if (item.PeopleDrinkingThisCoffe.Contains(peopleDrinkingCoffe))
                    {
                        int indexOfCurrentCoffe =
                            item.PeopleDrinkingThisCoffe.FindIndex(e => e.Equals(peopleDrinkingCoffe));

                        if (indexOfCurrentCoffe >= 0)
                        {
                            item.DrinkingCoffesForWeek.Add(coffeCount);
                            item.LeftCoffe -= coffeCount;
                            if (item.LeftCoffe <= 0)
                            {
                                Console.WriteLine($"Out of {item.CofeeType}");
                            }
                            break;
                        }
                    }
                }
            }
            Console.WriteLine("Coffee Left:");
            foreach (var coffeType in coffeList.OrderByDescending(a => a.LeftCoffe))
            {
                int totalDrinkingCoffeForType = coffeType.DrinkingCoffesForWeek.Sum();

                if (coffeType.CoffeMaxCount > totalDrinkingCoffeForType)
                {
                    int totalLeftCoffeForType = coffeType.CoffeMaxCount - totalDrinkingCoffeForType;
                    coffeType.LeftCoffe = totalLeftCoffeForType;
                    Console.WriteLine($"{coffeType.CofeeType} {totalLeftCoffeForType}");
                }
            }
            Console.WriteLine("For:");
            foreach (var item in coffeList.OrderBy(a => a.CofeeType))
            {
                foreach (var peope in item.PeopleDrinkingThisCoffe.OrderByDescending(a => a))
                {
                    if (item.LeftCoffe > 0)
                    {
                        Console.WriteLine($"{peope} {item.CofeeType}");
                    }
                }
            }
        }
    }
}