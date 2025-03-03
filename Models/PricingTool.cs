using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class PricingTool
    {
        public int PricingToolId { get; private set; }
        public string PricingToolName { get; private set; }

        public PricingTool(int pricingToolId, string pricingToolName)
        {
            PricingToolId = pricingToolId;
            PricingToolName = pricingToolName;
        }
    }

}
