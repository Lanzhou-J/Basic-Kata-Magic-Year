using System;
namespace Magic.Year
{
    public class Salary
    {
        private string _currency;
        private decimal _amount;
        public decimal Amount
        {
            get { return _amount; }
            set { _amount = value; }
        }
        private int _roundedAmount;
        public int RoundedAmount
        {
            get { return _roundedAmount; }
            set { _roundedAmount = value; }
        }

        public Salary(string currency, decimal amount, int roundedAmount)
        {
            _currency = currency;
            _amount = amount;
            _roundedAmount = roundedAmount;
        }

        public Salary(decimal amount, int roundedAmount)
        {
            _currency = "AUD";
            _amount = amount;
            _roundedAmount = roundedAmount;
        }        
        public Salary(int roundedAmount)
        {
            _currency = "AUD";
            _roundedAmount = roundedAmount;
            _amount = _roundedAmount;
        }
        public Salary(decimal amount)
        {
            _currency = "AUD";
            _amount = amount;
            _roundedAmount = RoundSalary(amount);
        }

        public Salary()
        {
            _currency = "AUD";
            _amount = decimal.Parse(Console.ReadLine());
            _roundedAmount = RoundSalary(_amount);
        }

        private int RoundSalary(decimal amount)
        {
            var truncate = Math.Truncate(amount);
            if ((amount - truncate) < (decimal) 0.5)
            {
                return (int)truncate;
            }
            else
            {
                return (int) truncate + 1;
            }
        }

    }
}