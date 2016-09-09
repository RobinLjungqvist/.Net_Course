using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public struct Book
    {
        public string title;
        public string author;
        public decimal price;
        public bool paperback;
        public Book(string title, string author, decimal price, bool paperback)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.paperback = paperback;
        }
    }

    public delegate void ProcessBookDelegate(Book book);
    public class BookDB
    {
        ArrayList list = new ArrayList();

        public void AddBook(string title, string author, decimal price, bool paperback)
        {
            list.Add(new Book(title, author, price, paperback));
        }
        public void ProcessPaperbackBooks(ProcessBookDelegate processBook)
        {
            foreach (Book b in list)
            {
                if (b.paperback)
                {
                    processBook(b);
                }
            }
        }
    }
}
namespace BookTestClient
{
    using DelegateDemo;

    class PriceTotaller
    {
        int countBooks = 0;
        decimal priceBooks = 0.0M;

        internal void AddBookToTotal(Book book)
        {
            countBooks += 1;
            priceBooks += book.price;
        }
        internal decimal AveragePrice()
        {
            return priceBooks / countBooks;
        }

    }

    public class Test
    {
        static void PrintTitle(Book b)
        {
            Console.WriteLine($"{b.title}");
        }

        static void Main(string[] args)
        {
            BookDB bookDB = new BookDB();

            Addbooks(bookDB);

            Console.WriteLine("Paperback Book Titles:");
            bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(PrintTitle));

            PriceTotaller totaller = new PriceTotaller();
            bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(totaller.AddBookToTotal));
            Console.Write("Average paperback book price ${0:#.##}", totaller.AveragePrice());
            Console.ReadKey();

        }
        static void Addbooks(BookDB bookDB)
        {
            bookDB.AddBook("    Nalle Puh", "Christopher Robbins", 9.50M, false);
            bookDB.AddBook("    Belgarath", "David Eddings", 39.95M, true);
            bookDB.AddBook("    Fellowship of the ring", "J.R.R. Tolkien", 129.95M, true);
            bookDB.AddBook("    Herpaderp", "Mannen", 12.00M, true);


        }
    }
}
