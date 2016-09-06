using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesWeekTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder demo
            Console.WriteLine("Using the stringbuilder.");
            var sb = new StringBuilder("-----| Fantastic Games |-----");
            sb.Append("\n");
            sb.AppendLine("World of Warcraft");
            sb.AppendLine("Deus ex" + "2");
            sb.AppendLine("Fallout");
            sb.AppendLine("Dota");

            Console.WriteLine(sb.ToString());
            Console.WriteLine($"sb has {sb.Length} amount of chars.\n");
            sb.Replace("2", " Invcincible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"sb has {sb.Length} amount of chars.");

            /* Example of implicit type conversion.
             * The function Add expects two integers but we pass two shorts.
             * Since short fits inside of int the compiler implicitly converts the shorts to int.
             * If we on the other hand tried to pass two integers to a function that expects shorts
             * we get compiler errors.
            */
            Console.WriteLine("\nFun with type conversions.");
            short numb1 = 9, numb2 = 10;
            Console.WriteLine($"{numb1} + {numb2} = {Add(numb1, numb2)}");


            /* In this example we don't get any compiler errors, but we get an aritmethic overflow
             * 
             * 
             */
            short numb3 = 30000, numb4 = 30000;
            short answer = (short)Add(numb3, numb4);
            Console.WriteLine($"{numb3} + {numb4} = {answer}");
            Console.ReadKey();
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
    }
}
