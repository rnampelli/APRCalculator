using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProducts {
    public class InterestTier {
        public decimal MinAmount { get; set; }
        public decimal MaxAmount { get; set; }
        public decimal Value { get; set; }

        public InterestTier(decimal MinAmount, decimal MaxAmount, decimal Value) {
            this.MinAmount = MinAmount;
            this.MaxAmount = MaxAmount;
            this.Value = Value;
        }
    }
}
