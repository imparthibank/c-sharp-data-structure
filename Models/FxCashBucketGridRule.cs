using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class FxCashBucketGridRule : GridRuleBase
    {
        public string CurrencyPair { get; private set; }
        public FxCashStreamingPublishBucketRule Result { get; private set; }

        public FxCashBucketGridRule(string currencyPair, FxCashStreamingPublishBucketRule result, long orderSequence)
        {
            CurrencyPair = currencyPair;
            Result = result;
            OrderSequence = orderSequence;
        }
    }

}
