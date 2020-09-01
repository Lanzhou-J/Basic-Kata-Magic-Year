using System;
namespace Magic.Year
{
    public class Work
    {
        public int StartYear { get; private set; }
        public Salary AnnualSalary { get; private set; }
        

        public Work(int startYear, Salary annualSalary)
        {
            StartYear = startYear;
            AnnualSalary = annualSalary;
            
        }

        public Work(string startYear)
        {
            Console.WriteLine("Please input your work start year: "); 
            StartYear = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Please input your annual salary: "); 
            AnnualSalary = new Salary();
        }
        
        public Salary CalculateMonthlySalary()
        {
            decimal monthlySalaryAmount = AnnualSalary.Amount/12;
            Salary monthlySalary = new Salary(amount:monthlySalaryAmount);
            return monthlySalary;
        }
    }
}