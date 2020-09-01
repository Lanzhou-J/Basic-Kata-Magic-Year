using System;
namespace Magic.Year
{
    public class UserInput
    {

        public User InstantiateNewUserBasedOnInput() {
            Console.WriteLine("Please input your name: "); 
            var firstname = Console.ReadLine(); 
            Console.WriteLine("Please input your surname: "); 
            var lastname = Console.ReadLine();
            return new User(firstname, lastname);
        }
        
        public Salary InstantiateAnnualSalaryBasedOnInput() {
            Console.WriteLine("Please enter your annual salary: "); 
            var annualSalary = int.Parse(Console.ReadLine());
            return new Salary(amount:annualSalary);
        }
        
        public Work InstantiateNewWorkBasedOnInput(Salary annualSalary) {
            Console.WriteLine("Please input your work start year: "); 
            int startYear = int.Parse(Console.ReadLine());
            return new Work(startYear:startYear, annualSalary: annualSalary);
        }
        
    }
}