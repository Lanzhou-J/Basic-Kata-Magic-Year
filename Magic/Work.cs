using System;
namespace Magic.Year
{
    public class Work
    {
        public int StartYear { get; private set; }
        public Salary AnnualSalary { get; private set; }
        public Salary MonthlySalary { get; private set; }

        public Work()
        {
            Console.WriteLine("Please input your work start year: "); 
            StartYear = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Please input your annual salary: "); 
            AnnualSalary = new Salary();
            MonthlySalary = CalculateMonthlySalary(AnnualSalary);
        }
        
        private Salary CalculateMonthlySalary(Salary annualSalary)
        {
            decimal monthlySalaryAmount = annualSalary.Amount/12;
            Salary monthlySalary = new Salary(amount:monthlySalaryAmount);
            return monthlySalary;
        }
    }
}