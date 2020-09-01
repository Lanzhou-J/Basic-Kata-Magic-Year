using System;
namespace Magic.Year
{
    public class User
    {
        private string Firstname { get;}

        private string Surname { get; set; }

        public User(string firstname, string surname){
            Firstname = firstname;
            Surname = surname;
        }

        public User(){
        }
        
        public string GetFullname()
        {
            if(Firstname != null || Surname != null)
            {
                var fullName = Firstname + " " + Surname;
                return fullName;
            }
            else
            {
                throw new InvalidNameException();
            }

        }
    }

    public class InvalidNameException : Exception
    {
        public InvalidNameException()
        {
        }
        
    }
}