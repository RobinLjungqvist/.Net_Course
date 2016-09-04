using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();

            var diceThrows = new Dictionary<int, int>();

            for (int i = 1; i < 7 ; i++)
            {
                diceThrows.Add(i, 0);
            }

            for (int i = 0; i < 1000; i++)
            {
                var diceThrow = rnd.Next(1, 7);
                diceThrows[diceThrow]++;

            }

            foreach (var pair in diceThrows)
            {
                Console.WriteLine($"Value: {pair.Key} Amount: {pair.Value}");
            }

            var numberOfTries = 0;
            foreach (var pair in diceThrows)
            {
                numberOfTries += pair.Value;
            }
            Console.WriteLine($"Number of tries: {numberOfTries}");
            Console.ReadKey();

        }
    }
}
