using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> inventory = new Dictionary<string, decimal>();
            List<Client> clients = new List<Client>();

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split('-').ToArray();
                inventory[tokens[0]] = decimal.Parse(tokens[1]);
            }
            string input = Console.ReadLine();
            while (input != "end of clients")
            {
                char[] delims = "-,".ToCharArray();
                string[] tokens = input.Split(delims, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (inventory.ContainsKey(tokens[1]))
                {
                    bool isContainThisCustomer = false;
                    foreach (var customer in clients)
                    {
                        if (customer.Name == tokens[0])
                        {
                            isContainThisCustomer = true;
                            if (customer.ShoppingBasket.ContainsKey(tokens[1]))
                            {
                                customer.ShoppingBasket[tokens[1]] += int.Parse(tokens[2]);
                            }
                            else
                            {
                                customer.ShoppingBasket[tokens[1]] = int.Parse(tokens[2]);
                            }

                        }

                    }
                    if (!isContainThisCustomer)
                    {
                        Client currClient = new Client(tokens[0], tokens[1], int.Parse(tokens[2]));
                        clients.Add(currClient);
                    }
                }
                input = Console.ReadLine();
            }

            decimal totalBill = 0;

            foreach (var client in clients.OrderBy(x => x.Name))
            {
                Console.WriteLine($"{client.Name}");
                decimal totalSum = 0;
                foreach (var currItem in client.ShoppingBasket)
                {
                    Console.WriteLine($"-- {currItem.Key} - {currItem.Value}");
                    totalSum += currItem.Value * inventory[currItem.Key];
                }
                Console.WriteLine($"Bill: {totalSum:f2}");
                totalBill += totalSum;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
        class Client
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShoppingBasket { get; set; }
            public Client(string name, string itemToBuy, int qty)
            {
                Name = name;
                ShoppingBasket = new Dictionary<string, int>() { { itemToBuy, qty } };
            }
            public double PricePerItem(string item)
            {
                if (ShoppingBasket.ContainsKey(item))
                {
                    return ShoppingBasket[item];
                }
                return -1;
            }
        }
    }
}
