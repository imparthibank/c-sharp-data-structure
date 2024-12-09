using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._11ConcurrentQueue
{
    internal class ConcurrentQueues
    {
        public ConcurrentQueue<string> GetLogMessages()
        {
            var logQueue = new ConcurrentQueue<string>();
            logQueue.Enqueue("Log1");
            logQueue.Enqueue("Log2");

            return logQueue;
        }
    }
}
