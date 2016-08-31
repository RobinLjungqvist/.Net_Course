using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibblan
{
    class Bok : IComparable
    {
        public string ISBN { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public int price { get; set; }

        public Bok(string isbn, string title, string author, int price)
        {
            this.ISBN = isbn;
            this.title = title;
            this.author = author;
            this.price = price;
        }
        public void Print()
        {
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Title: {title} | Author: {author}");
            Console.WriteLine($"Price: {price}");
            Console.WriteLine("---------------------------------------------------");

        }
        public int PriceInNumbers(int nrOfBooks)
        {
            var result = 0;
            return result;
        }
        public int CompareTo(object obj)
        {
            Bok b = (Bok)obj;
            return this.ISBN.CompareTo(b.ISBN);
        }
        public override bool Equals(object o)
        {
            Bok b = (Bok)o;
            return this.ISBN.Equals(b.ISBN);
        }

        public override int GetHashCode()
        {
            return ISBN.GetHashCode();
        }

    }
}
