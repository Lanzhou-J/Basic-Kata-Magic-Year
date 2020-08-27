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
            Console.WriteLine(newUser.Name);
            CalculationResult newCalculationResult = new CalculationResult(newUser);
            newCalculationResult.PrintCalculationResult();
        }
    }

    public class User
    {
        public string Name { get; private set; }

      public string Surname { get; private set; }

      public int WorkStartYear { get; private set; }

      public User(string userName, string userSurname, int userWorkStartYear){
        Name = userName;
        Surname = userSurname;
        WorkStartYear = userWorkStartYear;
      }

      public User(){
        Console.WriteLine("Please input your name: ");
        Name = Console.ReadLine();
        Console.WriteLine("Please input your surname: ");
        Surname = Console.ReadLine();
        Console.WriteLine("Please input your work start year: ");
        WorkStartYear = int.Parse(Console.ReadLine());
      }
    }
    
    public class CalculationResult
    {
        private readonly User _user;

        private readonly int _magicYear;

        private readonly string _fullName;

        public CalculationResult(User user, int magicYear, string fullName)
        {
            _user = user;
            _magicYear = magicYear;
            _fullName = fullName;
        }

        public CalculationResult(User user)
        {
            _user = user;
            _magicYear = calculateMagicYear(user);
            _fullName = formatFullName(user);
        }

        private string formatFullName(User user) {
            string fullName = user.Name + " " + user.Surname;
            return fullName;
        }

        private int calculateMagicYear(User user)
        {
            int magicYear = user.WorkStartYear + 65;
            return magicYear;
        }

        public void PrintCalculationResult()
        {
            Console.WriteLine();
            Console.WriteLine("Your magic age details are:"); 
            Console.WriteLine(); 
            Console.WriteLine("Name: "+_fullName); 
            Console.WriteLine("Magic Year: " + _magicYear);
        }

    }

    public class Salary
    {
        private string _currency;
        private decimal _amount;
        private int _roundedAmount;

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
            _roundedAmount = 0;
        }
        
        
    }
}