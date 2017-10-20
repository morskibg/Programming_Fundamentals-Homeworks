using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CofeeSupplies
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> coffeDatabase = new Dictionary<string, int>();
            List<CoffeUser> users = new List<CoffeUser>();
            string[] delimiters = Console.ReadLine().Split().ToArray();
            string userDelim = delimiters[0].Trim();
            string coffeDelim = delimiters[1].Trim();
            string input = Console.ReadLine();

            while (input != "end of info")
            {
                if (input.Contains(userDelim))
                {
                    string[] tokens = input
                        .Split(new string[] {userDelim}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    CoffeUser newUser = new CoffeUser();
                    newUser.Name = tokens[0];
                    newUser.PrefferedCoffe = tokens[1];
                    users.Add(newUser);
                    if (!coffeDatabase.ContainsKey(tokens[1]))
                    {
                        coffeDatabase[tokens[1]] = 0;
                    }
                }
                else
                {
                    string[] tokens = input
                        .Split(new string[] {coffeDelim}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    if (!coffeDatabase.ContainsKey(tokens[0]))
                    {
                        coffeDatabase[tokens[0]] = 0;
                    }
                    coffeDatabase[tokens[0]] += int.Parse(tokens[1]);
                }

                input = Console.ReadLine();
            }
            foreach (var coffe in coffeDatabase.Where(x => x.Value == 0))
            {
                Console.WriteLine($"Out of {coffe.Key}");
            }
            input = Console.ReadLine();

            while (input != "end of week")
            {
                char[] secondDelim = " ".ToCharArray();
                string[] tokens = input.Split(secondDelim, StringSplitOptions.RemoveEmptyEntries).ToArray();
                int currUserIdx = users.FindIndex(x => x.Name == tokens[0]);
                if (currUserIdx != -1)
                {
                    string prefCoffeByUser = users[currUserIdx].PrefferedCoffe;
                    if (coffeDatabase.ContainsKey(prefCoffeByUser))
                    {
                        int qtyFromPrefCoffe = coffeDatabase[prefCoffeByUser];
                        if (qtyFromPrefCoffe - int.Parse(tokens[1]) <= 0)
                        {
                            Console.WriteLine($"Out of {prefCoffeByUser}");
                            coffeDatabase[prefCoffeByUser] = 0;
                        }
                        else
                        {
                            coffeDatabase[prefCoffeByUser] -= int.Parse(tokens[1]);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Coffee Left:");
            List<string> remUsers = new List<string>();
            foreach (var coffeLeft in coffeDatabase
                .Where(kvp => kvp.Value > 0)
                .OrderByDescending(kvp => kvp.Value))
            {
                Console.WriteLine($"{coffeLeft.Key} {coffeLeft.Value}");
                
            }
            Console.WriteLine($"For:");
            Dictionary<string, string> lastSort = users
                .Where(x => coffeDatabase.ContainsKey(x.PrefferedCoffe) &&
                            coffeDatabase[x.PrefferedCoffe] > 0)
                            .ToDictionary(key => key.Name, value => value.PrefferedCoffe);
            foreach (var kvp in lastSort.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} {kvp.Value}");
            }
            
        }

        class CoffeUser
        {
            public string Name { get; set; }
            public string PrefferedCoffe { get; set; }
            public CoffeUser()
            {
                Name = null;
                PrefferedCoffe = null;

            }
        }
    }
}
