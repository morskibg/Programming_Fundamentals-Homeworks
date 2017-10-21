using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Book_Library_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines("input.txt");
            int n = int.Parse(input[0]);
            Library myLib = new Library();

            for (int i = 1; i <= n; i++)
            {
                string[] tokens = input[i].Split().ToArray();
                string title = tokens[0];
                string authorName = tokens[1];
                string publisherName = tokens[2];
                DateTime releaseDate = DateTime.ParseExact(tokens[3], "dd.MM.yyyy", null);
                string ISBN = tokens[4];
                decimal bookPrice = decimal.Parse(tokens[5]);
                Book currBook = new Book(title, authorName, publisherName,
                    releaseDate, ISBN, bookPrice);
                myLib.BookDatabase.Add(currBook);
            }
            DateTime givenaDate = DateTime.ParseExact(input[n + 1], "dd.MM.yyyy", null);
            File.WriteAllText("output.txt", "");
            foreach (var book in myLib.BookDatabase
                .Where(x => x.ReleaseDate > givenaDate)
                .OrderBy(x => x.ReleaseDate)
                .ThenBy(x => x.Title))
            {
                File.AppendAllText("output.txt", $"{book.Title} -> {book.ReleaseDate.ToString("dd.MM.yyyy")}" + Environment.NewLine);
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
