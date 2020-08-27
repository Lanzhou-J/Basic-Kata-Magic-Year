using System;

namespace Magic.Year
{
 
    public class MagicYearCalculator
    {

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the magic year calculator!");
        }


        public static void Main()
        {
            WelcomeUser();
            User newUser = new User();
            CalculationResult newCalculationResult = new CalculationResult(newUser);
            newCalculationResult.PrintCalculationResult();
        }
    }

    public class User
    {
        public string Name { get; private set; }

      public string Surname { get; private set; }

      public int WorkStartYear { get; private set; }

      public Salary AnnualSalary { get; private set; }

      public User(string userName, string userSurname, int userWorkStartYear, Salary annualSalary){
        Name = userName;
        Surname = userSurname;
        WorkStartYear = userWorkStartYear;
        AnnualSalary = annualSalary;
      }

      public User(){ 
          Console.WriteLine("Please input your name: "); 
          Name = Console.ReadLine(); 
          Console.WriteLine("Please input your surname: "); 
          Surname = Console.ReadLine(); 
          Console.WriteLine("Please input your work start year: "); 
          WorkStartYear = int.Parse(Console.ReadLine()); 
          Console.WriteLine("Please input your annual salary: "); 
          AnnualSalary = new Salary();
      }
    }
    
    public class CalculationResult
    {
        private readonly User _user;

        private readonly int _magicYear;

        private readonly string _fullName;

        private Salary _monthlySalary;

        public CalculationResult(User user, int magicYear, string fullName, Salary monthlySalary)
        {
            _user = user;
            _magicYear = magicYear;
            _fullName = fullName;
            _monthlySalary = monthlySalary;
        }

        public CalculationResult(User user)
        {
            _user = user;
            _monthlySalary = CalculateMonthlySalary(user);
            _magicYear = CalculateMagicYear(user);
            _fullName = FormatFullName(user);
        }

        private string FormatFullName(User user) {
            string fullName = user.Name + " " + user.Surname;
            return fullName;
        }

        private int CalculateMagicYear(User user)
        {
            int magicYear = user.WorkStartYear + 65;
            return magicYear;
        }

        private Salary CalculateMonthlySalary(User user)
        {
            decimal monthlySalaryAmount = user.AnnualSalary.Amount/12;
            Salary monthlySalary = new Salary(amount:monthlySalaryAmount);
            return monthlySalary;
        }

        public void PrintCalculationResult()
        {
            Console.WriteLine();
            Console.WriteLine("Your magic age details are:"); 
            Console.WriteLine(); 
            Console.WriteLine("Name: "+_fullName); 
            Console.WriteLine("Magic Year: " + _magicYear);
            Console.WriteLine("Monthly salary: "  + _monthlySalary.RoundedAmount);
        }

    }

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