using System;
namespace Magic.Year
{
    public class User
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        // public string Fullname { get; private set; }

        //public Work Work { get; private set; }

        // static 
        
        public User(string name, string surname){
            Name = name;
            Surname = surname;
        }

        public User(){
            
        }

        private string FormatFullName(string name, string surname) {
            string fullName = name + " " + surname;
            return fullName;
        }
    }
}