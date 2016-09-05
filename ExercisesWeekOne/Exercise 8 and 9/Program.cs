using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8_and_9
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var myIntList = new List<int>();
                FillCollection(myIntList);
                var Search = new BruteForceSearch();
                Search.GetNumber(myIntList, 256);
                //var result = Search.GetNumberByBinarySearch(myIntList, 256); // BinarySearch

                //Search.BubbleSort(myIntList);  //BubbleSort
                Search.ExchangeSort(myIntList);
                myIntList.ForEach(x => Console.WriteLine(x));

                Console.ReadKey(); 
            }
        }

        public static void FillCollection(List<int> collection)
        {
            var rnd = new Random();
            for (int i = 0; i < 200; i++)
            {
                int tal = rnd.Next(1, 1000);
                while (collection.Contains(tal))
                {
                    tal = rnd.Next(1, 1000);
                }
                collection.Add(tal);
            }
        }
    }
}
