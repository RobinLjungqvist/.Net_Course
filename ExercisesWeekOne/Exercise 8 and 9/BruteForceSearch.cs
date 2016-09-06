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
                int mid = (first + last) / 2;

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

        public void Swap(List<int> numberList, int a, int b)
        {
            int r = numberList[a];
            numberList[a] = numberList[b];
            numberList[b] = r;
        }

        public void BubbleSort(List<int> numberList)
        {
            var unSorted = true;
            var end = numberList.Count() - 1;
            while (unSorted == true)
            {
                unSorted = false;
                for (int i = 0; i < end; i++)
                {
                    if(numberList[i] > numberList[i + 1])
                    {
                        Swap(numberList, i, i + 1);
                        unSorted = true;
                    }

                }
                end--;
            }


        }

        public void ExchangeSort(List<int> numberList)
        {
            var end = numberList.Count();

            for (int i = 0; i < end; i++)
            {
                var minst = i;
                for (int j = i + 1; j < end; j++)
                {
                    if(numberList[minst] > numberList[j])
                    {
                        minst = j;
                    }
                }
                if(numberList[i] > numberList[minst])
                {
                    Swap(numberList, i, minst);
                }
            }

        }
    }
}
