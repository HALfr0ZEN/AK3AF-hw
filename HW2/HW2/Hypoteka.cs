using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace HW2
{
    internal class Hypoteka : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public double Debt { get; set; }
        public double Interest { get; set; }
        public int RepaymentPeriod { get; set; }

        private double _monthlyPay;
        public double MonthlyPay
        {
            get => _monthlyPay;
            set
            {
                _monthlyPay = value;
                OnPropertyChanged(nameof(MonthlyPay));
            }
        }
        public Command CommandGetMonthlyPay { get; set; }

        public Hypoteka()
        {
            Debt = 2000000;
            Interest = 3;
            RepaymentPeriod = 30;
            CommandGetMonthlyPay = new Command(GetMonthlyPay);
            GetMonthlyPay();
        }
        private void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        private void GetMonthlyPay()
        {
            double interestMonth = Interest / 12 / 100;
            double repaymentMonth = RepaymentPeriod * 12;
            MonthlyPay = Math.Round(Debt * interestMonth * (1 + (1 / (Math.Pow(interestMonth + 1, repaymentMonth) - 1))), 2);
        }
    }
}