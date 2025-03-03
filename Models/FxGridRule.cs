using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class FxGridRule
    {
        public string CurrencySetUp { get; private set; }
        public bool ApplyToInvertedCCy { get; private set; }
        public string TenorCodeStart { get; private set; }
        public string TenorCodeEnd { get; private set; }
        public string IsOnshore { get; private set; }
        public FxCashGridResultBase Result { get; private set; }

        public FxGridRule(string currencySetUp, bool applyToInvertedCCy, string tenorCodeStart, string tenorCodeEnd, string isOnshore, FxCashGridResultBase result)
        {
            CurrencySetUp = currencySetUp;
            ApplyToInvertedCCy = applyToInvertedCCy;
            TenorCodeStart = tenorCodeStart;
            TenorCodeEnd = tenorCodeEnd;
            IsOnshore = isOnshore;
            Result = result;
        }
    }

}
