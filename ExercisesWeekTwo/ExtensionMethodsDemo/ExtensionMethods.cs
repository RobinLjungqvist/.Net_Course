using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDemo
{
    static class ExtensionMethods
    {
        public static void DisplayDefiningAssembly(this object obj)
        {
            Console.WriteLine($"{obj.GetType().Name} lives here => {Assembly.GetAssembly(obj.GetType()).GetName().Name}");
        }

        public static int ReverseDigits(this int i)
        {
            char[] digits = i.ToString().ToCharArray();
            Array.Reverse(digits);
            string newDigits = new string(digits);
            return int.Parse(newDigits);
        }

        public static string ReverseString(this string str)
        {
            char[] letters = str.ToArray();
            Array.Reverse(letters);
            string reversedString = new string(letters);
            return reversedString;
        }
    }
}
