using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class FxCashGridMarginResult : FxCashGridResultBase
    {
        public decimal BidMargin { get; private set; }
        public decimal AskMargin { get; private set; }
        public MarginUnit MarginUnit { get; private set; }

        public FxCashGridMarginResult(decimal bidMargin, decimal askMargin, MarginUnit marginUnit, bool reject)
        {
            BidMargin = bidMargin;
            AskMargin = askMargin;
            MarginUnit = marginUnit;
            Reject = reject;
        }
    }

}
