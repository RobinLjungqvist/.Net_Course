using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaDemo
{
    class Program
    {
        delegate void TestDelegate(string s);
        static void Main(string[] args)
        {
            TestDelegate myDel = n => { string s = n + " " + "World"; Console.WriteLine(s); };
            myDel("Hello");

            //TraditionalDelegateSyntax();
            //AnonymousMethodSyntax();
            LambdaExpressionSyntax();

            Console.ReadKey();
        }

        private static void TraditionalDelegateSyntax()
        {
            var list = new List<int>{ 20, 1, 4, 8, 9, 44 };
            Predicate<int> callBack = IsEvenNumber;
            var evenNumbers = list.FindAll(callBack);

            Console.WriteLine("Here are your even numbers:");
            list.ForEach(x => Console.WriteLine(x));

        }

        private static bool IsEvenNumber(int i)
        {
            return (i % 2) == 0;
        }

        private static void AnonymousMethodSyntax()
        {
            var list = new List<int> { 20, 1, 4, 8, 9, 44 };

            var EvenNumbers = list.FindAll(delegate (int i) { return (i % 2) == 0; });

            Console.WriteLine("Here are your even numbers:");
            list.ForEach(x => Console.WriteLine(x));

        }


        private static void LambdaExpressionSyntax()
        {
            var list = new List<int> { 20, 1, 4, 8, 9, 44 };
            var EvenNumbers = list.FindAll(x => (x % 2) == 0); // Lambda über alles.
            Console.WriteLine("Here are your even numbers:");
            list.ForEach(x => Console.WriteLine(x));
        }
    }
}
