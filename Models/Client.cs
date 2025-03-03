using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class Client
    {
        public long ClientId { get; private set; }

        public Client(long clientId)
        {
            ClientId = clientId;
        }
    }

}
