using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_8_and_9
{
    class BruteForceSearch
    {
        public bool GetNumber(List<int> numberList, int nrToSearch)
        {
            var counter = 0;
            var sw = new Stopwatch();
            sw.Start();
            foreach (var number in numberList)
            {
                if(number == nrToSearch)
                {
                    sw.Stop();
                    Console.WriteLine($"You searched for {nrToSearch} it was found and has the index {counter}. It took {sw.Elapsed.TotalMilliseconds}");
                    return true;
                }
                counter++;
            }
            Console.WriteLine("Number was not found.");
            return false;

        }

        public int GetNumberByBinarySearch(List<int> numberList, int nrToSearch)
        {
            numberList.Sort();

            var first = numberList[0];
            var last = numberList[numberList.Count() - 1];

            var sw = new Stopwatch();

            sw.Start();

            while (first <= last)
            {
                var mid = (first + last) / 2;

                if(nrToSearch > mid)
                {
                    first = mid + 1;
                }
                else if(nrToSearch < mid)
                {
                    last = mid - 1;
                }
                else
                {
                    sw.Stop();
                    if (numberList.IndexOf(mid) >= 1)
                    {

                        Console.WriteLine("Number was found at index {0} with binary search. It took {1}",
                                                            numberList.IndexOf(mid), sw.Elapsed.TotalMilliseconds);
                        
                    }
                    
                    return mid;
                }
            }
            return -1;


        }

    }
}
