using System;
namespace Magic.Year
{
    public class EmployeeReport
    {
        private readonly string _fullname;
        private readonly int _monthlySalary;
        private readonly int _magicYear;

        public EmployeeReport(string fullname, int monthlySalary, int magicYear)
        {
            _fullname = fullname;
            _monthlySalary = monthlySalary;
            _magicYear = magicYear;
        }
        

        // private int CalculateMagicYear(User user)
        // {
        //     int magicYear = user.Work.StartYear + 65;
        //     return magicYear;
        // }
        
        public void PrintReport()
        {
            Console.WriteLine();
            Console.WriteLine("Your magic age details are:"); 
            Console.WriteLine(); 
            Console.WriteLine("Name: "+ _fullname); 
            Console.WriteLine("Magic Year: " + _magicYear);
            Console.WriteLine("Monthly salary: "  + _monthlySalary);
        }

    }
}