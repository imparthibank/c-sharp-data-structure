using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._08SortedDictionary
{
    internal class SortedDictionaries
    {
        public SortedDictionary<DateTime, string> GetEventLog()
        {
            var eventLog = new SortedDictionary<DateTime, string>
            {
                {DateTime.Now.AddMinutes(-2), "Event 1"},
                {DateTime.Now, "Event 2"}
            };

            return eventLog;
        }
    }
}
