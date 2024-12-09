using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._03Dictionaries
{
    public class Dictionaries
    {
        public Dictionary<int, string> GetUsers()
        {
            var users = new Dictionary<int, string>
            {
                { 1, "Parthi" },
                { 2, "Mathi" },
                { 3, "Vina" },
                { 4, "Thiru" }
            };

            users[5] = "Aadhvi";


            return users;


        }
    }
}
