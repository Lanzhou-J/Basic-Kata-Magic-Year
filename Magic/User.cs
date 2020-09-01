using System;
namespace Magic.Year
{
    public class User
    {
        private string Firstname { get;}

        public string Surname { get; private set; }

        public User(string firstname, string surname){
            Firstname = firstname;
            Surname = surname;
        }

        public User(){
            
        }

        public string FormatFullName() {
            string fullName = Firstname + " " + Surname;
            return fullName;
        }
    }
}