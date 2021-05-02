using System;
using System.Collections.Generic;
using System.Text;
using AcademyAppClassLibrary.Entities.Enums;

namespace AcademyAppClassLibrary.Entities.Models
{
    public class Student : Person
    {

        public Subject CurrentSubject { get; set; }
        public Dictionary<Subject, Grade> Grades { get; set; } = new Dictionary<Subject, Grade>();

        public Student() : base()
        {
        }

        public Student(string firstName, string lastName, string username, string password, Subject currentSubject, Dictionary<Subject, Grade> grades) : base(firstName, lastName, username, password)
        {
            Role = Role.Student;
            CurrentSubject = currentSubject;
            Grades = grades;
        }

        public void PrintFullName()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            Console.WriteLine($"{FirstName} {LastName}");

            Console.ResetColor();
        }

        public override void PrintInfo()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"\nHello {FirstName} {LastName} :)\n" +
                $"You are currently listening to the {CurrentSubject} course.\n" +
                $"Here's a list of your grades:\n");

            foreach (var subjectGradePair in Grades)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write($"- {subjectGradePair.Key}:");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($" grade {subjectGradePair.Value}");
            }

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
