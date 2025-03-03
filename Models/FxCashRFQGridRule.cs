using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class FxCashRFQGridRule : GridRuleBase
    {
        public string AmountStart { get; private set; }
        public string AmountEnd { get; private set; }
        public string AmountCurrency { get; private set; }
        public long TenorDateStart { get; private set; }
        public long TenorDateEnd { get; private set; }
        public string ExternalCustomerId { get; private set; }

        public FxCashRFQGridRule(string amountStart, string amountEnd, string amountCurrency, long tenorDateStart, long tenorDateEnd, string externalCustomerId, string media, long orderSequence)
        {
            AmountStart = amountStart;
            AmountEnd = amountEnd;
            AmountCurrency = amountCurrency;
            TenorDateStart = tenorDateStart;
            TenorDateEnd = tenorDateEnd;
            ExternalCustomerId = externalCustomerId;
            Media = media;
            OrderSequence = orderSequence;
        }
    }
}
