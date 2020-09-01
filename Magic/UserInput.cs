using System;
namespace Magic.Year
{
    public class UserInput
    {

        public User CollectUserDetails() {
            Console.WriteLine("Please input your name: "); 
            var firstname = Console.ReadLine(); 
            Console.WriteLine("Please input your surname: "); 
            var lastname = Console.ReadLine();
            return new User(firstname, lastname);
        }
        
        public Salary CollectSalaryDetails() {
            Console.WriteLine("Please enter your annual salary: "); 
            var annualSalary = int.Parse(Console.ReadLine());
            return new Salary(amount:annualSalary);
        }
        
        public Work CollectWorkDetails(Salary annualSalary) {
            Console.WriteLine("Please input your work start year: ");
            var input = Console.ReadLine();
            var startYear = 2000;
            // if statement - unit tests (true / false)
            if (input != null)
            {
                startYear = int.Parse(input);
                
            }
            return new Work(startYear:startYear, annualSalary: annualSalary);
        }
        
    }
}