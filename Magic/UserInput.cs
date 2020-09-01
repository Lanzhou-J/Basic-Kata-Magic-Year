using System;
namespace Magic.Year
{
    public class UserInput
    {

        private string Ask(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }

        private int AskInt(string question)
        {
            try
            {
                System.Console.Write(question);
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                throw new FormatException("Input was not a number");
            }  
        }

        public User CollectUserDetails() {
            var firstname = Ask("Please input your name: ");
            var lastname = Ask("Please input your surname: ");
            return new User(firstname, lastname);
        }
        
        public Salary CollectSalaryDetails() {
            var annualSalary = AskInt("Please enter your annual salary: ");
            return new Salary(amount:annualSalary);
        }
        
        public Work CollectWorkDetails(Salary annualSalary) {
            var startYear = AskInt("Please input your work start year: ");
            return new Work(startYear:startYear, annualSalary: annualSalary);
        }
        
    }
}