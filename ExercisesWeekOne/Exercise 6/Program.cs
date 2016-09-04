using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<Student> studentQueue = new Queue<Student>();

            studentQueue.Enqueue(new Student("Pelle", 25));
            studentQueue.Enqueue(new Student("Olle", 34));
            studentQueue.Enqueue(new Student("Danne", 45));
            studentQueue.Enqueue(new Student("Oskar", 23));
            studentQueue.Enqueue(new Student("Fredrik", 55));

            foreach (var student in studentQueue)
            {
                student.PrintStudent();
            }
            do
            {
                Console.WriteLine($"{studentQueue.First().FullName} has Graduated!");
                studentQueue.Dequeue();
            } while (studentQueue.Count > 0);

            Console.ReadKey();


        }
    }
}
