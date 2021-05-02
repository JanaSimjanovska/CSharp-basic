using System;
using System.Collections.Generic;
using System.Text;
using AcademyAppClassLibrary.Entities.Enums;

namespace AcademyAppClassLibrary.Entities.Models
{
    public class Admin : Person
    {
        public Admin() : base()
        {
        }

        public Admin(string firstName, string lastName, string username, string password) : base(firstName, lastName, username, password)
        {
            Role = Role.Admin;
           
        }

        public override void PrintInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine($"{FirstName} {LastName}");

            Console.ResetColor();
        }
    }
}
