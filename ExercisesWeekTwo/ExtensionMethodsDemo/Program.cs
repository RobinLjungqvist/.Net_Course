using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Extension Methods.");
            // THE int has assumed a new identitity.
            int myInt = 123456789;
            myInt.DisplayDefiningAssembly();

            myInt.ReverseDigits();
            Console.WriteLine("{0}", myInt );

            var hello = "!dlroW olleH";

            var reversedHello = hello.ReverseString();

            Console.WriteLine(reversedHello);

            Console.ReadKey();

        }


    }
}
