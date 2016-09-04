using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesWeekOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var listInt = new List<int>();

            listInt.Add(5);
            listInt.Add(15);
            listInt.Add(25);

            listInt.AddRange(new List<int> { 1, 2, 3, 4, 5, 6 });

            for (int i = 0; i < listInt.Count; i++)
            {
                Console.WriteLine($"Index: {i} Value: {listInt[i]}");
            }

            Console.WriteLine($"List contains the number 3: {listInt.Contains(3)}");

            Console.WriteLine($"List contains the number 7: {listInt.Contains(7)}");

            for (int i = 0; i < listInt.Count; i++)
            {
                for (int j = 0; j < listInt.Count; j++)
                {
                    if (i != j && listInt[i] == listInt[j])
                    {
                        listInt.RemoveAt(i);
                    }
                }
            }

            listInt.RemoveAt(3);

            int counter = 0;
            foreach (var number in listInt)
            {

                Console.WriteLine($"Index {counter}: {number}");
                counter++;
            }

            var evenNumbers = listInt.Where(x => ((x % 2) == 0)).ToList();
            Console.WriteLine("Even Numbers in the collection:");
            evenNumbers.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("----------");
            listInt.Sort();
            listInt.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("List has been sorted");
            Console.WriteLine("----------");
            Console.WriteLine($"The highest number is: { listInt.Max()}");
            Console.WriteLine("----------");
            listInt.Reverse();
            listInt.ForEach(x => Console.WriteLine(x));
            Console.WriteLine("The list has been reversed.");



            Console.ReadKey();
        }
    }
}
