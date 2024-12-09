using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure._05Queues
{
    internal class Queues
    {
        /// <summary>
        /// Processing customer service requests in the order they are received (FIFO)
        /// </summary>
        /// <returns>serviceQueue.Dequeue()</returns>
        public Queue<string> GetCustomerServiceRequests()
        {
            var serviceQueue = new Queue<string>();
            
            serviceQueue.Enqueue("Request 1");
            serviceQueue.Enqueue("Request 2");
            return serviceQueue;
        }
    }
}
