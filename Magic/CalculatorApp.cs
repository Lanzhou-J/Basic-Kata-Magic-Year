using System;

namespace Magic.Year
{
 
    public class CalculatorApp
    {

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the magic year calculator!!!!!");
        }


        public static void Main()
        {
            WelcomeUser();
            UserInput newUserInput = new UserInput(); 
            User newUser = newUserInput.InstantiateNewUserBasedOnInput();
            Console.WriteLine(newUser.FormatFullName());
            Salary annualSalary = newUserInput.InstantiateAnnualSalaryBasedOnInput();
            Work newWork = newUserInput.InstantiateNewWorkBasedOnInput(annualSalary);
            Console.WriteLine(newWork.MonthlySalary.RoundedAmount);
        }
    }


    



    
}