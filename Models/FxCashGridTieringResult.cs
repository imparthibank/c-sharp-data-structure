using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Models
{
    public class FxCashGridTieringResult : FxCashGridResultBase
    {
        public string Tiering { get; private set; }

        public FxCashGridTieringResult(string tiering, bool reject)
        {
            Tiering = tiering;
            Reject = reject;
        }
    }

}
