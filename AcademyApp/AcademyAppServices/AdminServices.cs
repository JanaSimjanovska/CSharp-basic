using AcademyAppClassLibrary.Entities.Enums;
using AcademyAppClassLibrary.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyAppServices
{
    public static class AdminServices
    {


        #region Add a member 

        #region Validate basic info
        public static bool ValidateFirstName(string firstName)
        {
            try
            {


                while (firstName.Length < 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nFirst name must be at least 2 characters long.\n" +
                "\nPlease try again.");
                    LoginMenu.PressAnyKey();


                    return false;
                }


            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                LoginMenu.PressAnyKey();


            }

            return true;

        }


        public static bool ValidateLastName(string lastName)
        {

            try
            {
                while (lastName.Length < 2)
                {
                    Console.Clear();
                    Console.WriteLine("\nLast name must be at least 2 characters long.\n" +
                "\nPlease try again.");
                    LoginMenu.PressAnyKey();


                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine(ex.Message);
                LoginMenu.PressAnyKey();
            }
            return true;

        }

        #endregion


        #region Validate new username
        public static bool ValidateUsername(List<Person> members, string username)
        {

            foreach (Person member in members)
            {
                if (username == member.UserName)
                {
                    Console.Clear();
                    Console.WriteLine("\nUsername already exists. Please try again.");
                    LoginMenu.PressAnyKey();

                    return false;
                }
            }

            if (username.Length < 4)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nUsername must be at least 4 characters long. Please try again");
                Console.ResetColor();
                LoginMenu.PressAnyKey();


                return false;
            }
            else
                return true;

        }


        #endregion


        #region Validate new password

        public static bool ValidatePassword(List<Person> members, string password)
        {

            foreach (Person member in members)
            {
                if (password == member.Password)
                {
                    Console.Clear();
                    Console.WriteLine("\nPassword already exists. Please try again.");
                    LoginMenu.PressAnyKey();

                    return false;
                }
            }

            if (password.Length < 8)
            {
                Console.Clear();
                Console.WriteLine("\nPassword must be at least 8 characters long. Please try again");
                LoginMenu.PressAnyKey();


                return false;
            }
            else
                return true;

        }

        #endregion


        #region Validate Member (used for validating shared properties by all members)

        public static Tuple<string, string, string, string> ValidateMember(List<Person> members)
        {

            string firstName;
            string lastName;
            string userName;
            string password;

            do
            {
                Console.Clear();
                Console.WriteLine("\nEnter first name:\n");

                firstName = Console.ReadLine();
            }
            while (!ValidateFirstName(firstName));

            do
            {
                Console.Clear();

                Console.WriteLine("\nEnter last name:\n");

                lastName = Console.ReadLine();
            }
            while (!ValidateFirstName(lastName));

            

            do
            {
                Console.Clear();

                Console.WriteLine("\nEnter username:\n");

                userName = Console.ReadLine();
            }
            while (!ValidateUsername(members, userName));


            do
            {
                Console.Clear();

                Console.WriteLine("\nEnter password:\n");

                password = Console.ReadLine();
            }
            while (!ValidatePassword(members, password));


            return new Tuple<string, string, string, string>(firstName, lastName, userName, password);
        }

        #endregion


        #region Method for adding academy members

        public static Tuple<List<Person>, List<Admin>, List<Trainer>, List<Student>> AddAMember(List<Person> members, List<Admin> admins, List<Trainer> trainers, List<Student> students, Admin loggedInAdmin)
        {
            Console.Clear();

            Console.WriteLine("\nWould you like to add a new:\n" +
                "[1] Admin\n" +
                "[2] Trainer\n" +
                "[3] Student");


            int adminChoice = int.Parse(Console.ReadLine());

            switch (adminChoice)
            {
                case 1:
                    var (adminFirstName, adminLastName, adminUsername, adminPass) = ValidateMember(members);
                    Admin newAdmin = new Admin(adminFirstName, adminLastName, adminUsername, adminPass);
                    members.Add(newAdmin);
                    admins.Add(newAdmin);
                    Console.Clear();
                    Console.WriteLine($"\nSuccessfully added new Admin!");
                    Console.Write($"\nNew admin full name: ");
                    newAdmin.PrintInfo();
                    Console.WriteLine($"\nNew admin username: {newAdmin.UserName}");
                    LoginMenu.PressAnyKey();
                    Console.Clear();
                    AdminMenu(members, admins, trainers, students, loggedInAdmin);
                    break;

                case 2:
                    var (trainerFirstName, trainerLastName, trainerUsername, trainerPass) = ValidateMember(members);
                    Trainer newTrainer = new Trainer(trainerFirstName, trainerLastName, trainerUsername, trainerPass);
                    members.Add(newTrainer);
                    trainers.Add(newTrainer);
                    Console.Clear();
                    Console.WriteLine($"\nSuccessfully added new Trainer!");
                    Console.Write($"\nNew trainer full name:");
                    newTrainer.PrintInfo();
                    Console.WriteLine($"\nNew trainer username: {newTrainer.UserName}");
                    LoginMenu.PressAnyKey();
                    Console.Clear();
                    AdminMenu(members, admins, trainers, students, loggedInAdmin);
                    break;

                case 3:
                    var (studentFirstName, studentLastName, studentUsername, studentPass) = ValidateMember(members);
                    Student newStudent = new Student(studentFirstName, studentLastName, studentUsername, studentPass, Subject.NoData, new Dictionary<Subject, Grade>()); 
                    members.Add(newStudent);
                    students.Add(newStudent);
                    Console.Clear();
                    Console.WriteLine($"\nSuccessfully added new Student!");
                    Console.Write($"\nNew student full name: ");
                    newStudent.PrintFullName();
                    Console.WriteLine($"\nNew student username: {newStudent.UserName}");
                    LoginMenu.PressAnyKey();
                    Console.Clear();
                    AdminMenu(members, admins, trainers, students, loggedInAdmin);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine($"\nNo such option. Please try again.");
                    LoginMenu.PressAnyKey();
                    AdminMenu(members, admins, trainers, students, loggedInAdmin);
                    break;
            }
            return new Tuple<List<Person>, List<Admin>, List<Trainer>, List<Student>>(members, admins, trainers, students);
        }

        #endregion

        #endregion


        #region Remove a member 

        public static Tuple<List<Person>, List<Admin>, List<Trainer>, List<Student>> RemoveAMember(List<Person> members, List<Admin> admins, List<Trainer> trainers, List<Student> students, Admin loggedInAdmin)
        {
            Console.Clear();

            Console.WriteLine("\nWould you like to remove:\n" +
                "[1] An Admin\n" +
                "[2] A Trainer\n" +
                "[3] A Student");

            int adminChoice = int.Parse(Console.ReadLine());


            switch (adminChoice)
            {
                case 1:

                    Person adminToRemove = LoginMenu.LoginVerification(members);

                    if (adminToRemove == null)
                    {
                        Console.Clear();
                        Console.WriteLine("\nSorry, no such admin. Please try again.");
                        LoginMenu.PressAnyKey();
                        Console.Clear();
                        break;

                    }

                    if (adminToRemove == loggedInAdmin)
                    {
                        Console.Clear();
                        Console.WriteLine("\nCan't remove yourself");
                        LoginMenu.PressAnyKey();
                        Console.Clear();
                        break;


                    }

                    Console.Clear();
                    Console.Write($"\nSuccessfully removed admin ");
                    adminToRemove.PrintInfo();
                    members.Remove(adminToRemove);
                    admins.Remove((Admin)adminToRemove);
                    LoginMenu.PressAnyKey();
                    Console.Clear();
                    break;

                case 2:

                    Person trainerToRemove = LoginMenu.LoginVerification(members);

                    if (trainerToRemove == null)
                    {
                        Console.Clear();
                        Console.WriteLine("\nSorry, no such trainer. Please try again.");
                        LoginMenu.PressAnyKey();

                        break;

                    }

                    Console.Clear();
                    Console.Write($"\nSuccessfully removed trainer ");
                    trainerToRemove.PrintInfo();
                    members.Remove(trainerToRemove);
                    trainers.Remove((Trainer)trainerToRemove);
                    LoginMenu.PressAnyKey();
                    Console.Clear();
                    break;

                case 3:

                    Person studentToRemove = LoginMenu.LoginVerification(members);

                    if (studentToRemove == null)
                    {
                        Console.Clear();
                        Console.WriteLine("\nSorry, no such student. Please try again.");
                        LoginMenu.PressAnyKey();
                        break;
                    }

                    Console.Clear();
                    Console.Write($"\nSuccessfully removed student {studentToRemove.FirstName} {studentToRemove.LastName}");
                    members.Remove(studentToRemove);
                    students.Remove((Student)studentToRemove);
                    LoginMenu.PressAnyKey();
                    Console.Clear();
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine($"\nNo such option. Please try again.");
                    LoginMenu.PressAnyKey();
                    AdminMenu(members, admins, trainers, students, loggedInAdmin);
                    break;
            }

            return new Tuple<List<Person>, List<Admin>, List<Trainer>, List<Student>>(members, admins, trainers, students);
        }

        #endregion


        #region Login as admin and admin menu options
        public static void LoginAsAdmin(List<Person> members, List<Admin> admins, List<Trainer> trainers, List<Student> students)
        {
            Person loggedInAdmin = LoginMenu.LoginVerification(members);

            if (loggedInAdmin == null)
            {
                Console.Clear();

                Console.WriteLine("\nSorry, no such administrator. Maybe you just misspelled your username and\\or password?\n" +
                    "In any case, please try again.");

                LoginMenu.PressAnyKey();

                return;
            }

            Console.Clear();
            Console.Write($"\nWelcome Admin ");
            loggedInAdmin.PrintInfo();
            AdminMenu(members, admins, trainers, students, loggedInAdmin);


        }


        public static void AdminMenu(List<Person> members, List<Admin> admins, List<Trainer> trainers, List<Student> students, Person loggedInAdmin)
        {

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nWould you like to:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("[1] Add an Academy member\n" +
               "[2] Remove an Academy member\n" +
               "[3] Go back to login menu\n" +
               "[4] Exit AcademyApp");

            Console.ForegroundColor = ConsoleColor.White;

            int chosenOption = int.Parse(Console.ReadLine());

            switch (chosenOption)
            {
                case 1:
                    AddAMember(members, admins, trainers, students, (Admin)loggedInAdmin);
                    AdminMenu(members, admins, trainers, students, loggedInAdmin);
                    break;

                case 2:
                    RemoveAMember(members, admins, trainers, students, (Admin)loggedInAdmin);
                    AdminMenu(members, admins, trainers, students, loggedInAdmin);
                    break;

                case 3:
                    LoginMenu.MainMenuLogin(members, admins, trainers, students);
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine($"\nUntil next time admin!");
                    LoginMenu.PressAnyKey();
                    LoginMenu.MainMenuLogin(members, admins, trainers, students);
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine($"\nNo such option. Please try again.");
                    LoginMenu.PressAnyKey();
                    AdminMenu(members, admins, trainers, students, loggedInAdmin);
                    break;
            }
        }

        #endregion


    }
}
