using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Library myLib = new Library();
            
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split().ToArray();
                string title = tokens[0];
                string authorName = tokens[1];
                string publisherName = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", null);
                string ISBN = tokens[4];
                decimal bookPrice = decimal.Parse(tokens[5]);
                Book currBook = new Book(title, authorName, publisherName, 
                    releaseDate, ISBN, bookPrice);
                myLib.AddBook(currBook);
            }
           Dictionary<string, decimal> filteredByPrice = new Dictionary<string, decimal>();
            foreach (var currBook in myLib.BookDatabase)
            {
                string currAuthor = currBook.AuthorsName;
                if (!filteredByPrice.ContainsKey(currAuthor))
                {
                    filteredByPrice[currAuthor] = myLib.GetSumOfSingleAuthors(currAuthor);
                }
                
            }
            foreach (var author in filteredByPrice
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key))
            {
                Console.WriteLine($"{author.Key} -> {author.Value:f2}");
            }
        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> BookDatabase { get; set; }

        public Library()
        {
            BookDatabase = new List<Book>();
        }
        public void AddBook(Book book)
        {
            BookDatabase.Add(book);
        }

        public decimal GetSumOfSingleAuthors(string currAuthor)
        {
            decimal sum = 0;
            foreach (var book in BookDatabase.Where(x => x.AuthorsName == currAuthor))
            {
                sum += book.Price;
            }
            return sum;
        }

    }
    class Book
    {
        public string Title { get; set; }
        public string AuthorsName { get; set; }
        public string PublishersName { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public Book() { }
        public Book(string title, string authorsName, string publishersName,
            DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            AuthorsName = authorsName;
            PublishersName = publishersName;
            ReleaseDate = releaseDate;
            ISBN = isbn;
            Price = price;
        }
    }
}
