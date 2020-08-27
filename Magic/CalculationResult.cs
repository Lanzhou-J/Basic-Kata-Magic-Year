using System;
namespace Magic.Year
{
    public class CalculationResult
    {
        private readonly User _user;

        private readonly int _magicYear;

        public CalculationResult(User user, int magicYear)
        {
            _user = user;
            _magicYear = magicYear;
        }

        public CalculationResult(User user)
        {
            _user = user;
            _magicYear = CalculateMagicYear(user);
        }

        private int CalculateMagicYear(User user)
        {
            int magicYear = user.Work.StartYear + 65;
            return magicYear;
        }
        
        public void PrintCalculationResult()
        {
            Console.WriteLine();
            Console.WriteLine("Your magic age details are:"); 
            Console.WriteLine(); 
            Console.WriteLine("Name: "+ _user.Fullname); 
            Console.WriteLine("Magic Year: " + _magicYear);
            Console.WriteLine("Monthly salary: "  + _user.Work.MonthlySalary.RoundedAmount);
        }

    }
}