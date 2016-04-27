using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProducts {
    class InterestCalculator {
        protected Loan loan { get; set; }
        public InterestCalculator(Loan Loan) {
            this.loan = Loan;
        }

        public decimal calculateInterest(DateTime fromDate, DateTime toDate, decimal amount) {
            decimal result = 0m;
            return result;
        }
    }
}
