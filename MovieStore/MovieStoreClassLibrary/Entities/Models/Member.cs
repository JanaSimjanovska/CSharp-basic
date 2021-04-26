using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreClassLibrary.Entities.Enums;

namespace MovieStoreClassLibrary.Entities.Models
{
    public class Member
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }

        public Member()
        {
        }

        public Member(string firstName, string lastName, string age, string userName, string password, string phoneNumber, DateTime dateOfRegistration)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} | Registered on: {DateOfRegistration}");
        }

    }
}
