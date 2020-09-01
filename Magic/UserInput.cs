using System;
namespace Magic.Year
{
    public class UserInput
    {
      // public string FirstNameInput {get; private set;}
      // public string LastNameInput {get; private set;}

      // public int StartYearInput {get; private set;}

      // public decimal AmountInput {get; private set;}

      public User collectUserInput() {

            User newUser = new User();
            Console.WriteLine("Please input your name: "); 
            newUser.Name = Console.ReadLine(); 
            Console.WriteLine("Please input your surname: "); 
            newUser.Surname = Console.ReadLine(); 
            // Console.WriteLine("Please input your work start year: "); 
            // StartYearInput = int.Parse(Console.ReadLine()); 
            // Console.WriteLine("Please input your annual salary: "); 
            // AmountInput = decimal.Parse(Console.ReadLine());
          return newUser;// new User(first, last)
      }


    }
}