using System;

namespace Magic.Year
{
 
    public class MagicYearCalculator
    {

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the magic year calculator!!!!!");
        }


        public static void Main()
        {
            WelcomeUser();
            User newUser = new User();
            CalculationResult newCalculationResult = new CalculationResult(newUser);
            newCalculationResult.PrintCalculationResult();
        }
    }


    



    
}