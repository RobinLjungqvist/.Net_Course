using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDal.Models
{
    public class Author
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AuthorID { get; set; }

        public Author()
        {

        }
        public Author(int ID, string fName, string lName)
        {
            AuthorID = ID;
            FirstName = fName;
            LastName = lName;
        }
    }
}
