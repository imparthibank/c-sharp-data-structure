using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class FxCashStreamingPublishBucketResult
    {
        public string Buckets { get; private set; }

        public FxCashStreamingPublishBucketResult(string buckets)
        {
            Buckets = buckets;
        }
    }

}
