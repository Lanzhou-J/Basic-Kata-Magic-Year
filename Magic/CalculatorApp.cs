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
            User newUser = newUserInput.InstantiateNewUser();
            Salary annualSalary = newUserInput.InstantiateAnnualSalary();
            Work newWork = newUserInput.InstantiateNewWork(annualSalary);
        }
    }


    



    
}