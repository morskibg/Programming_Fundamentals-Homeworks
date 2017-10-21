using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            string[] Phrases = new string[]
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] Events = new string[]
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] Authors = new string[]
            {
                "Diana", "Petya", "Stella",
                "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] Cities = new string[]
            {
                "Burgas", "Sofia",
                "Plovdiv", "Varna", "Ruse"
            };
            
            
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{Phrases[rand.Next(0, Phrases.Length)]} {Events[rand.Next(0, Events.Length)]} " +
                                  $"{Authors[rand.Next(0, Authors.Length)]} {Cities[rand.Next(0, Cities.Length)]}");
                //Console.Write($"{Phrases[rand.Next(0, Phrases.Length)]}");
                //Console.Write($" {Events[rand.Next(0, Events.Length)]}");
                //Console.Write($" {Authors[rand.Next(0, Authors.Length)]}");
                //Console.Write($" {Cities[rand.Next(0, Cities.Length)]}");
                //Console.WriteLine();
            }
        }
    }
}
