using System;
using System.Collections.Generic;
using System.Text;
using AcademyAppClassLibrary;
using AcademyAppClassLibrary.Entities.Enums;
using AcademyAppClassLibrary.Entities.Models;

namespace AcademyAppServices
{
    public static class LoginMenu
    {


        #region Press any key 
        public static void PressAnyKey()
        {
            Console.WriteLine("\nPress any key to continue");
            char anyKey = Console.ReadKey(true).KeyChar;
        }

        #endregion


        #region Login menu 

        public static Person LoginVerification(List<Person> members)
        {
            Console.Clear();

            Console.WriteLine("\nEnter username:");
            string username = Console.ReadLine();

            Console.WriteLine("\nEnter password:");
            string password = Console.ReadLine();

            foreach (Person member in members)
            {
                if (username == member.UserName && password == member.Password) return member;
            }
            return null;
        }

        public static void MainMenuLogin(List<Person> members, List<Admin> admins, List<Trainer> trainers, List<Student> students)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n=======================================================\n");
            Console.ResetColor();

            Console.WriteLine("Welcome to SEDC Academy :)\n");


            Console.WriteLine("Are you logging in as:\n" +
                 "[1] Admin\n" +
                 "[2] Trainer\n" +
                 "[3] Student\n");
             Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\n=======================================================\n");
            Console.ResetColor();


            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    AdminServices.LoginAsAdmin(members, admins, trainers, students);
                    break;
                case 2:
                    TrainerServices.LoginAsTrainer(members, admins, trainers, students);
                    break;
                case 3:
                    StudentServices.LoginAsStudent(members);
                    break;
                
                default:
                    Console.Clear();
                    Console.WriteLine("\nNo such choice. Please try again");
                    LoginMenu.PressAnyKey();
                    MainMenuLogin(members, admins, trainers, students);
                    break;
            }
        }
        #endregion


    }

}
