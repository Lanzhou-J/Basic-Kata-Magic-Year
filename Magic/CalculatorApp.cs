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
            newUserInput.InstantiateNewUserBasedOnInput();
            Work work = new Work()
            User newUser = new User(newUserInput.FirstNameInput, newUserInput.LastNameInput, work);
            User newUser = new User(newUserInput.FirstNameInput, newUserInput.LastNameInput);// User class instantiates work
            CalculationResult newCalculationResult = new CalculationResult(newUser);
            newCalculationResult.PrintCalculationResult();
        }
    }


    



    
}