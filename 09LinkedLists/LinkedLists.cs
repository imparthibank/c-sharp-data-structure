using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._09LinkedLists
{
    internal class LinkedLists
    {
        public LinkedList<string> GetBrowserHistory()
        {
            var browserHistory = new LinkedList<string>();
            browserHistory.AddLast("Page1");
            browserHistory.AddLast("Page2");
            browserHistory.AddFirst("Page0");
            return browserHistory;
        }
    }
}
