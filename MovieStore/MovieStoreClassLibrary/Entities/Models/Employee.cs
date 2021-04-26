using System;
using System.Collections.Generic;
using System.Text;
using MovieStoreClassLibrary.Entities.Enums;

namespace MovieStoreClassLibrary.Entities.Models
{
    public class Employee : Member
    {
        private double Salary { get; set; }
        public double? Bonus { get; set; }
        public int HoursPerMonth { get; set; }

        public Employee(string firstName, string lastName, string age, string userName, string password, string phoneNumber, DateTime dateOfRegistration, int hoursPerMonth) : base(firstName, lastName, age, userName, password, phoneNumber, dateOfRegistration)
        {       
            HoursPerMonth = hoursPerMonth;
            Salary = 300;
            Role = Role.Employee;
        }

        public Employee()
        {
        }

        public double SetBonus()
        {
            if (HoursPerMonth < 160)
            {
                Bonus = null;
                return 0;
            }
            else
                Bonus = 0.3;

            return (double)Bonus;
        }

        public double SetSalary()
        {
            if(Bonus == null)
            {
                Console.WriteLine($"No bonus this month. Salary is {Salary} euro.");
                return Salary;
            }

            else
            {
                Salary += HoursPerMonth * (double)Bonus;
                Console.WriteLine($"Salary is now {Salary} euro.");
            }
            
            return Salary;
        }

    }
}
