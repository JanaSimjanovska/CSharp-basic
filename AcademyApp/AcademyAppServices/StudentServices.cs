using System;
using System.Collections.Generic;
using System.Text;
using AcademyAppClassLibrary.Entities.Models;
using AcademyAppClassLibrary.Entities.Enums;

namespace AcademyAppServices
{
    public static class StudentServices
    {

        

        public static void LoginAsStudent(List<Person> members)
        {
            Person loggedInStudent = LoginMenu.LoginVerification(members);

            if (loggedInStudent == null)
            {
                Console.Clear();
                Console.WriteLine("\nSorry, no such student. Maybe you just misspelled your username and\\or password?\n" +
                    "In any case, please try again.");

                LoginMenu.PressAnyKey();

                return;
            }

            loggedInStudent.PrintInfo();

            
            LoginMenu.PressAnyKey();

        }

    }
}
