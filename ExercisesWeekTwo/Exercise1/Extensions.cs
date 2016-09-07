using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    static class Extensions
    {
        static public Person FindPerson(this List<Person> collection, string name)
        {
            foreach (var person in collection)
            {
                if(person.FullName == name)
                {
                    return person;
                }
            }
            return null;
        }

        public static List<Person> SortSurname(this List<Person> personList)
        {
            //var surNames = new List<string>();
            var newList = new List<Person>();

            //foreach (var person in personList)
            //{
            //    surNames.Add(person.SurName);
            //}
            //var Names = from name in surNames
            //            orderby name ascending
            //            select name;


            //foreach (var name in Names.ToList())
            //{
            //    foreach (var person in personList)
            //    {
            //        if(person.SurName == name)
            //        {
            //            newList.Add(person);
            //        }
            //    }
            //}

            newList = personList.OrderBy(x => x.SurName).ToList();

            return newList;
            

        }
    }
}
