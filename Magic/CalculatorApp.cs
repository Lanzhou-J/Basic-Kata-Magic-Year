using System;

namespace Magic.Year
{
 
    public static class CalculatorApp
    {
        private static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the magic year calculator!");
        }


        public static void Main()
        {
            WelcomeUser();
            UserInput newUserInput = new UserInput();

            var adding = true;
            while (adding)
            {
                try
                {
                    User newUser = newUserInput.CollectUserDetails();
                    Salary annualSalary = newUserInput.CollectSalaryDetails();
                    Work newWork = newUserInput.CollectWorkDetails(annualSalary);
                    Calculator newCalculator = new Calculator();

                    EmployeeReport newReport = new EmployeeReport(user:newUser, work:newWork, calculator:newCalculator);
                    newReport.PrintReport();

                    adding = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Please try again");
                }
            }
        }
    }


    



    
}