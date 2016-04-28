using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanProducts
{
    class InterestCalculator
    {
        protected Loan loan { get; set; }
        protected decimal interest { get; set; }
        public InterestCalculator(Loan Loan)
        {
            this.loan = Loan;
        }

        public decimal CalculateInterest(DateTime FromDate, DateTime ToDate, decimal Amount) {
            decimal result = 0.00m;
            decimal AbsoluteAmount = System.Math.Abs(Amount);
            int period = ToDate.Date.Subtract(FromDate.Date).Days;
            decimal tierAmount = 0.00m, residue = AbsoluteAmount;
            if (period == 0 || AbsoluteAmount == 0)
                return result;
            foreach (InterestTier tier in this.loan.InterestTiers.Where(x=> x.MinAmount < AbsoluteAmount).OrderByDescending(x => x.MaxAmount)) {
                tierAmount = residue > tier.MinAmount ? residue - tier.MinAmount : 0;
                result = result + (tierAmount * (tier.Value / 100.00m) / 365 * period);
                residue = residue - tierAmount;
            }
            return result;
        }
    }
}
