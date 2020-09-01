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
            var fullName = Firstname + " " + Surname;
            return fullName;

        }
    }


}