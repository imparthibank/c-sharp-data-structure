using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._04HashSets
{
    public class HashSets
    {
        public HashSet<string> GetProgrammingLanguages()
        {
            var programmingLanguages = new HashSet<string>
            {
                "C#",
                "Java",
                "TypeScript"
            };            

            return programmingLanguages;
        }
    }
}
