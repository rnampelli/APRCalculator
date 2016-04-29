using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProducts {
    public class Fee {
        public string Name { get; set; }
        public bool AccrueInterestOn { get; set; }
        public bool isProrated { get; set; }
        public FeesType FeeType { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountPaid { get; set; }
        public DateTime date { get; set; }

        public Fee(string Name, FeesType Type, decimal Amount, DateTime Date, bool AccruedInterestOn, bool IsProrated) {
            this.Name = Name;
            this.FeeType = Type;
            this.Amount = Amount;
            this.date = Date;
            this.AccrueInterestOn = AccruedInterestOn;
            this.isProrated = IsProrated;
            this.AmountPaid = 0.00m;
        }
    }
}
