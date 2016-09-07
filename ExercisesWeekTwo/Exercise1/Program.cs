using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var personList = new List<Person>();

            personList.Add(new Person("Olle", "Persson", "Gatan 123", 24));
            personList.Add(new Person("Pelle", "Olsson", "Gatan 43", 22));
            personList.Add(new Person("Daniel", "Bengtsson", "Gatan 33", 43));
            personList.Add(new Person("Lisa", "Sävås", "Gatan 14", 33));
            personList.Add(new Person("Karolina", "Ohliw", "Gatan 21", 27));

            var person = personList.FindPerson("Olle Kersson");

            if(person != null)
            {
                Console.WriteLine($"{person.FullName} was found");
            }
            else
            {
                Console.WriteLine("Person not found.");
            }

            personList.ForEach(x => Console.WriteLine(x.FullName));

           var newlist = personList.SortSurname();

            newlist.ForEach(x => Console.WriteLine(x.FullName));

            Console.ReadKey();

        }
    }
}
