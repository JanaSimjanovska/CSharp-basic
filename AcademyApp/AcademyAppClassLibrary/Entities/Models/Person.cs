using System;
using System.Collections.Generic;
using System.Text;
using AcademyAppClassLibrary.Entities.Enums;

namespace AcademyAppClassLibrary.Entities.Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public Role Role { get; set; }
        public Person()
        {

        }

        public Person(string first, string last, string username, string password)
        {
            FirstName = first;
            LastName = last;
            UserName = username;
            Password = password;
        }

        public abstract void PrintInfo();


    }
}
