using System;

namespace HW1
{
    class Hypoteka
    {
        public double Debt { get; set; }
        public double Interest { get; set; }
        public int RepaymentPeriod { get; set; }
        public double MonthlyPay { get; set; }

        public Hypoteka()
        {
            Debt = 2000000;
            Interest = 3;
            RepaymentPeriod = 30;
            MonthlyPay = GetMonthlyPay();
        }

        private double GetMonthlyPay()
        {
            double interestMonth = Interest / 12 / 100;
            double repaymentMonth = RepaymentPeriod * 12;

            return Math.Round(Debt * interestMonth * (1 + (1 / (Math.Pow(interestMonth + 1, repaymentMonth) - 1))), 2);
        }
    }
}