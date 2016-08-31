using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibblan
{
    class Bibliotek
    {
        public static ArrayList BookList = new ArrayList();
        public static Hashtable HashList = new Hashtable();

        public Bibliotek()
        {
            var bok1 = new Bok("100", "Nalle Puh", "Alfredo Robin", 250);
            var bok2 = new Bok("105", "Friday", "Robinsson Crusoe", 250);
            var bok3 = new Bok("102", "Belgarath, Callous", "Callous Eddings", 250);

            BookList.Add(bok1);
            BookList.Add(bok2);
            BookList.Add(bok3);

            HashList.Add(bok1.ISBN, bok1);
            HashList.Add(bok2.ISBN, bok2);
            HashList.Add(bok3.ISBN, bok3);
            


        }

        static void Main(string[] args)
        {
            var bibblan = new Bibliotek();
            bibblan.Meny();
        }
        public void Meny()
        {
            do
            {
                Console.WriteLine("------Menu------");
                Console.WriteLine("1. Ny Bok.");
                Console.WriteLine("2. Lista Böcker (ArrayList)");
                Console.WriteLine("3. Sök Bok (ArrayList");
                Console.WriteLine("4. Sortera Böcker efter ISBN");
                Console.WriteLine("5. Sortera böcker efter författare/titel");
                Console.WriteLine("6. Lista Böcker(Hashtable)");
                Console.WriteLine("7. Sök Böcker (Hashtable)");
                Console.WriteLine("0. Avsluta");



                var key = Console.ReadKey(true);

                switch (key.Key)
                {
                    case ConsoleKey.D1:
                        NyBok();
                        break;
                    case ConsoleKey.D2:
                        ListaList();
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine("Mata in ISBN: ");
                        var isbn = Console.ReadLine();
                        var bok = SearchList(isbn);
                        if(bok != null)
                        {
                            bok.Print();
                        }
                        else
                        {
                            Console.WriteLine("Boken hittades inte.");
                        }
                        break;
                    case ConsoleKey.D4:
                        SortListISBN();

                        break;
                    case ConsoleKey.D5:
                        SortListNamn();


                        break;
                    case ConsoleKey.D6:
                        ListaHash();


                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine("Mata in ISBN: ");
                        var hashsearchIsbn = Console.ReadLine();
                        var hashbok = SearchHash(hashsearchIsbn);
                        if (hashbok != null)
                        {
                            hashbok.Print();
                        }
                        else
                        {
                            Console.WriteLine("Boken hittades inte.");
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.D0:
                        return;
                }
                Console.ReadKey();

                Console.Clear();
            } while (true);
        }
        public void NyBok()
        {
            Console.WriteLine("Enter Title: ");
            var title = Console.ReadLine();
            Console.WriteLine("Enter Author: ");
            var author = Console.ReadLine();

            Console.WriteLine("Enter ISBN: ");
            var isbn = Console.ReadLine();

            Console.WriteLine("Enter Price: ");
            int price = 0;
            if(!int.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("You didn't enter a number");
                return;
            }
            var bok = new Bok(isbn, title, author, price);
            BookList.Add(bok);
            HashList.Add(bok.ISBN, bok);
        }
        public void ListaList()
        {
            foreach(Bok bok in BookList)
            {
                bok.Print();
            }
        }
        public static void ListaHash()
        {
            ICollection e = HashList.Values;

            foreach(Bok bok in e)
            {
                bok.Print();
            }

        }
        public Bok SearchList(string isbn)
        {
            foreach(var obj in BookList)
            {
                var bok = (Bok)obj;
                if(bok.ISBN == isbn)
                {
                    return bok;
                }
            }
            return null;

        }
        public Bok SearchHash(string isbn)
        {
           foreach(DictionaryEntry e in HashList)
            {
                if(e.Key.ToString() == isbn)
                {
                    var bok = (Bok)e.Value;
                    return bok;
                }
            }
            return null;
        }
        public static void SortListISBN()
        {
            BookList.Sort();
            Console.WriteLine("Sorted after ISBN");
        }
        public static void SortListNamn()
        {
            var comparer = new BokComparator();
            BookList.Sort(comparer);
            Console.WriteLine("Sorted after Author name and Title");
        }
    }
}
