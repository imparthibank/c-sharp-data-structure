using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._10ConcurrentDictionary
{
    internal class ConcurrentDictionaries
    {
        public ConcurrentDictionary<string, int> GetSharedCollectionOfCounters()
        {
            ConcurrentDictionary<string, int> wordCounts = new ConcurrentDictionary<string, int>();
            
            wordCounts.AddOrUpdate("hello", 1, (key, oldValue) => oldValue + 1);
            wordCounts.AddOrUpdate("world", 2, (key, oldValue) => oldValue + 1);
            
            return wordCounts;
        }
    }
}
