using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictInt = new Dictionary<int, int>();

            dictInt.Add(0, 5);
            dictInt.Add(1, 15);
            dictInt.Add(2, 25);

            AddRange(new List<int> { 1, 2, 3, 4, 5, 6 }, dictInt);

            printDictionary(dictInt);
            CheckForValue(5, dictInt);
            CheckForValue(8, dictInt);



            Console.WriteLine("--------------");
            dictInt = RemoveDuplicateEntries(dictInt);
            dictInt.Remove(3);
            printDictionary(dictInt);
            Console.WriteLine("--------------");
            Console.WriteLine("Removed duplicate and the number at index 3");


            Console.ReadKey();
        }

        public static void AddRange(List<int> numbers, Dictionary<int, int> dict)
        {
            var currentIndex = dict.Count;

            foreach (var number in numbers)
            {
                dict.Add(currentIndex, number);
                currentIndex++;
            }
        }
        public static void CheckForValue(int x, Dictionary<int,int> dict)
        {
            Console.WriteLine($"Dictionary contains value {x}: {dict.ContainsValue(x)}");
        }
        public static Dictionary<int,int> RemoveDuplicateEntries(Dictionary<int,int> dict)
        {
            var resultDictionary = new Dictionary<int, int>();

            foreach (var item in dict)
            {
                var counter = 0;
                foreach(var value in dict.Values)
                {
                    if(item.Value == value)
                    {
                        counter++;
                    }
                }
                if(counter == 1)
                {
                    resultDictionary.Add(item.Key, item.Value);
                }
            }
            return resultDictionary;

        }

        public static void printDictionary(Dictionary<int,int> dict)
        {
            foreach (var keyValuePair in dict)
            {
                Console.WriteLine($"Index: {keyValuePair.Key} Value: {keyValuePair.Value}");
            }
        }
    }
}
