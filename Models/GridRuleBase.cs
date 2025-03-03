using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public abstract class GridRuleBase
    {
        public long OrderSequence { get; protected set; }
        public string Media { get; protected set; }
    }
}
