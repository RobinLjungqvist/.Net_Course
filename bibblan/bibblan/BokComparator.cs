using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibblan
{
    class BokComparator : IComparer
    {
        public int Compare(object x, object y)
        {
            var bookOne = (Bok)x;
            var bookTwo = (Bok)y;

            var first = $"{bookOne.author} {bookOne.title}";
            var second = $"{bookTwo.author} {bookTwo.title}";

            return String.Compare(first, second);
        }
    }
}
