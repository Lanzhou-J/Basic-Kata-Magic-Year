using System;
namespace Magic.Year
{
    public class EmployeeReport
    {
        private readonly User _user;
        private readonly Work _work;
        private readonly Calculator _calculator;

        public EmployeeReport(User user, Work work, Calculator calculator)
        {
            _user = user;
            _work = work;
            _calculator = calculator;
        }

        public void PrintReport()
        {
            Console.WriteLine();
            Console.WriteLine("Your magic age details are:"); 
            Console.WriteLine(); 
            Console.WriteLine("Name: "+ _user.FormatFullname()); 
            Console.WriteLine("Magic Year: " + _calculator.CalculateMagicYear(_work.StartYear));
            Console.WriteLine("Monthly salary: "  + _work.CalculateMonthlySalary().RoundedAmount);
        }

    }
}