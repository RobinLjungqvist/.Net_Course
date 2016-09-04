using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_7
{
    class Student
    {
        public int Age { get; set; }
        public string FullName { get; set; }

        public Student(string name, int age)
        {
            this.FullName = name;
            this.Age = age;
        }

        public void PrintStudent()
        {
            Console.WriteLine($"Name: {FullName} Age: {Age}");
        }
    }
}
