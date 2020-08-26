using System;

namespace Magic.Year
{
 
    public class MagicYearCalculator
    {

        public static void WelcomeUser()
        {
            Console.WriteLine("Welcome to the magic year calculator!");
        }


        public static void Main()
        {
            WelcomeUser();
            User newUser = new User();
            Console.WriteLine(newUser.Name);
        }
    }

    public class User
    {
      private string name;
      public string Name{
        get {return name;}
        set {name = value;}
      }
      private string surname;
      public string Surname{
        get {return surname;}
        set {surname = value;}
      }
      private int workStartYear; 
      public int WorkStartYear{
        get {return workStartYear;}
        set {workStartYear = value;}
      }

      public User(string userName, string userSurname, int userWorkStartYear){
        name = userName;
        surname = userSurname;
        workStartYear = userWorkStartYear;
      }

      public User(){
        Console.WriteLine("Please input your name: ");
        name = Console.ReadLine();
        Console.WriteLine("Please input your surname: ");
        surname = Console.ReadLine();
        Console.WriteLine("Please input your work start year: ");
        workStartYear = int.Parse(Console.ReadLine());
      }
    }
}