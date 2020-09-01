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
        // public Work InstantiateNewWorkBasedOnInput() {
        //     Console.WriteLine("Please input your work start year: "); 
        //     var startYear = Console.ReadLine(); 
        //     
        //     return new Work(startYear);
        // }
        
    }
}