using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public enum GridDataType
    {
        Margin,
        Tiering,
        Streaming,
        Bucket,
        Blocks
    }

    public enum ProfileType
    {
        Unknown,
        Default,
        Standard,
        ClientPool,
        Custom
    }

    public enum MarginUnit
    {
        Unknown,
        Bps,
        Pips,
        Percentage
    }

}
