using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class ClientProfileMapping
    {
        public Profile Profile { get; private set; }
        public Client Client { get; private set; }
        public bool IsInherited { get; private set; }

        public ClientProfileMapping(Profile profile, Client client, bool isInherited)
        {
            Profile = profile;
            Client = client;
            IsInherited = isInherited;
        }
    }

}
