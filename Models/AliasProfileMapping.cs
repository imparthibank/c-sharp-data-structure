using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DataStructure.Models
{
    public class AliasProfileMapping
    {
        public Profile Profile { get; private set; }
        public TechnicalAlias Alias { get; private set; }

        public AliasProfileMapping(Profile profile, TechnicalAlias alias)
        {
            Profile = profile;
            Alias = alias;
        }
    }

}
