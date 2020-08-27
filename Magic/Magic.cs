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
      private string _name;
      public string Name{
        get {return _name;}
        set {_name = value;}
      }
      private string _surname;
      public string Surname{
        get {return _surname;}
        set {_surname = value;}
      }

      public int WorkStartYear { get; set; }

      public User(string userName, string userSurname, int userWorkStartYear){
        _name = userName;
        _surname = userSurname;
        WorkStartYear = userWorkStartYear;
      }

      public User(){
        Console.WriteLine("Please input your name: ");
        _name = Console.ReadLine();
        Console.WriteLine("Please input your surname: ");
        _surname = Console.ReadLine();
        Console.WriteLine("Please input your work start year: ");
        WorkStartYear = int.Parse(Console.ReadLine());
      }
    }
}