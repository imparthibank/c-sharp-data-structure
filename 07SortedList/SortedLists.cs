using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._07SortedList
{
    internal class SortedLists
    {
        public SortedList<int, string> GetStundentsTopMarksByAutoSort()
        {
            var students = new SortedList<int, string>()
            {
                {100,"Parthi" },
                {190,"Mathi" },
                {130,"Vina" },
                {160,"Thiru" },
            };

            return students;
        }
    }
}
