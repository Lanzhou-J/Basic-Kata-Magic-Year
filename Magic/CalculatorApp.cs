using System;

namespace Magic.Year
{
 
    public class CalculatorApp
    {

        public static void WelcomeUser()
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
                    User newUser = newUserInput.InstantiateNewUser();
                    Salary annualSalary = newUserInput.InstantiateAnnualSalary();
                    Work newWork = newUserInput.InstantiateNewWork(annualSalary);
                
                    var fullname = newUser.FormatFullname();
            
                    Calculator newCalculator = new Calculator();
                    var magicYear = newCalculator.CalculateMagicYear(newWork.StartYear);

                    var monthlySalary = newWork.CalculateMonthlySalary().RoundedAmount;
            
                    EmployeeReport newReport = new EmployeeReport(fullname:fullname, magicYear:magicYear, monthlySalary:monthlySalary);
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