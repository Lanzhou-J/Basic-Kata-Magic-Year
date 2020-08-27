using System;
namespace Magic.Year
{
    public class User
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Fullname { get; private set; }

        public Work Work { get; private set; }
        
        public User(string name, string surname, Work work){
            Name = name;
            Surname = surname;
            Work = work;
            Fullname = name + surname;
        }

        public User(){
            Console.WriteLine("Please input your name: "); 
            Name = Console.ReadLine(); 
            Console.WriteLine("Please input your surname: "); 
            Surname = Console.ReadLine(); 
            Work newWork = new Work();
            Work = newWork;
            Fullname = FormatFullName(Name, Surname);
        }
        private string FormatFullName(string name, string surname) {
            string fullName = name + " " + surname;
            return fullName;
        }
    }
}