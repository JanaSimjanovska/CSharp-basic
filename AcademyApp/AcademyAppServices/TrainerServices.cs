using System;
using System.Collections.Generic;
using System.Text;
using AcademyAppClassLibrary.Entities.Enums;
using AcademyAppClassLibrary.Entities.Models;

namespace AcademyAppServices
{
    public static class TrainerServices
    {
     

        #region Display all students method

        public static void DisplayAllStudents(List<Student> students)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nThese are all the students of the academy:");
            for (int i = 0; i < students.Count; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine($"\n{i + 1}. {students[i].FirstName} {students[i].LastName}");
            }

            Console.ResetColor();
            LoginMenu.PressAnyKey();
            Console.Clear();

        }

        #endregion


        #region Display subjects info method

        public static void SubjectsInfo(List<Student> students)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nThese are all subjects of the academy\n");

            int subjectNum = 1;
            foreach (Subject subject in Enum.GetValues(typeof(Subject)))
            {
                if (subject == Subject.NoData) continue;

                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write($"{subjectNum}. ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write($"Subject: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"{ subject}");
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.Write(" | ");
                    Console.ForegroundColor = ConsoleColor.Cyan;

                    Console.Write("Number of attending students: ");

                    int subjectListenersCounter = 0;

                    // Logikava ovde e da pokaze za site predmeti kolku studenti gi slusale, nezavisno dali im se Current subject ili nekoi od vekje islusanite. Barem jas taka razbrav deka treba da se prikaze. Vo slucaj da treba da se prikazat samo slusatelite na predmet kojsto im e Current subject, bi stoel samo vtoriot if. I obratno, ako treba da se pokaze brojka na studenti samo za vekje islusanite predmeti, kje stoi samo prviot if.

                    foreach (Student student in students)
                    {
                        if (student.Grades.ContainsKey(subject)) subjectListenersCounter++;
                        if (student.CurrentSubject == subject) subjectListenersCounter++;
                    }

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{subjectListenersCounter}\n");
                    subjectNum++;
                }
                
            }

            Console.ResetColor();
            LoginMenu.PressAnyKey();
            Console.Clear();

        }

        #endregion


        #region Display info for particular student

        public static void DisplayChosenStudentInfo(List<Student> students)
        {
            Console.Clear();

            Console.WriteLine("\nEnter student's first name:");
            string studentFirstName = Console.ReadLine();

            Console.WriteLine("\nEnter student's last name:");
            string studentLastName = Console.ReadLine();

            Console.Clear();

            Student studentsInfoToDisplay = null;
            foreach (Student student in students)
            {
                if (studentFirstName == student.FirstName && studentLastName == student.LastName)
                {
                    studentsInfoToDisplay = student;
                    int i = 1;
                    Console.ForegroundColor = ConsoleColor.DarkCyan;

                    if(studentsInfoToDisplay.Grades.Count == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        Console.WriteLine("\nCurrently there is no info for this student's subjects.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"\nThese are all subjects of the student {student.FirstName} {student.LastName}\n");

                        foreach (var key in studentsInfoToDisplay.Grades.Keys)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write($"{i}. ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write($"Subject: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine($"{ key}\n");

                            i++;
                        }
                    }
                    
                }
            }

            if (studentsInfoToDisplay == null)
            {
                Console.WriteLine("\nSorry no such student. Please make sure first name and last name are correct and match\n" +
                    "If you want to try again, choose corresponding option from menu.");

            }

            Console.ResetColor();
            LoginMenu.PressAnyKey();
            Console.Clear();
        }

        #endregion


        #region Login as trainer and trainer menu options

        public static void LoginAsTrainer(List<Person> members, List<Admin> admins, List<Trainer> trainers, List<Student> students)
        {
            Person loggedInTrainer = LoginMenu.LoginVerification(members);

            if (loggedInTrainer == null)
            {
                Console.Clear();

                Console.WriteLine("\nSorry, no such trainer. Maybe you just misspelled your username and\\or password?\n" +
                    "In any case, please try again.");

                LoginMenu.PressAnyKey();

                return;
            }

            Console.Clear();
            Console.Write($"\nWelcome trainer ");
            loggedInTrainer.PrintInfo();
            TrainerMenu(members, admins, trainers, students);

        }

        public static void TrainerMenu(List<Person> members, List<Admin> admins, List<Trainer> trainers, List<Student> students)
        {


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\nWould you like to:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("[1] See all students of the Academy\n" +
               "[2] See all subjects of the Academy\n" +
               "[3] See all subjects of a particular student\n" +
               "[4] Go back to login menu\n" +
               "[5] Exit AcademyApp");

            Console.ForegroundColor = ConsoleColor.White;

            int chosenOption = int.Parse(Console.ReadLine());

            switch (chosenOption)
            {
                case 1:

                    DisplayAllStudents(students);
                    TrainerMenu(members, admins, trainers, students);
                    break;

                case 2:
                    SubjectsInfo(students);
                    TrainerMenu(members, admins, trainers, students);

                    break;

                case 3:
                    DisplayChosenStudentInfo(students);
                    TrainerMenu(members, admins, trainers, students);

                    break;

                case 4:
                    LoginMenu.MainMenuLogin(members, admins, trainers, students);
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine($"\nUntil next time trainer! Thank you for using AcademyApp.");
                    LoginMenu.PressAnyKey();
                    LoginMenu.MainMenuLogin(members, admins, trainers, students);

                    break;

                default:
                    Console.Clear();
                    Console.WriteLine($"\nNo such option. Please try again.");
                    LoginMenu.PressAnyKey();
                    TrainerMenu(members, admins, trainers, students);
                    break;
            }
        }

        #endregion

        
    }
}
