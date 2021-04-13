using System;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 05 Homework");
            Console.WriteLine("----------------------------");

            #region Task 01

            Console.WriteLine("Task 01");

            //## Task 1
            // * Print the current date with time
            // * Print the date that is 10 years from now
            // * Print the date that is 2 months and 15 days ago
            // * Print day of week for the next 8 - th March
            // * Print day of week of last year's Valentine's day

            // Prints the current date with time
            DateTime currentDateAndTime = DateTime.Now;
            string currentDateAndTimeFormat = string.Format("Today is {0:dd-MMMM-yyyy}, {0:dddd}, and the time is {0:t}.", currentDateAndTime);
            Console.WriteLine(currentDateAndTimeFormat);

            // Prints the date that is 10 years from now
            DateTime tenYearsFromNow = currentDateAndTime.AddYears(10);
            string tenYearsFromNowFormat = string.Format("Ten years from today it will be {0:dd-MMMM-yyyy}, {0:dddd}.", tenYearsFromNow);
            Console.WriteLine(tenYearsFromNowFormat);

            // Prints the date that is 2 months and 15 days ago
            DateTime twoMonthsFifteenDaysAgo = currentDateAndTime.AddMonths(-2).AddDays(-15);
            string twoMonthsFifteenDaysAgoFormat = string.Format("Two months and fifteen days ago it was {0:dd-MMMM-yyyy}, {0:dddd}.", twoMonthsFifteenDaysAgo);
            Console.WriteLine(twoMonthsFifteenDaysAgoFormat);

            // Prints day of week for the next 8 - th March
            DateTime eighthOfMarch2022 = new DateTime(2022, 3, 8);
            string eighthOfMarch2022Format = string.Format("The eighth of March in 2022 falls on a {0:dddd}.", eighthOfMarch2022);
            Console.WriteLine(eighthOfMarch2022Format);

            // Prints day of week of last year's Valentine's day
            DateTime valentinesDay2020 = new DateTime(2020, 2, 14);
            string valentinesDay2020Format = string.Format("Last year's Valentine's day fell on a {0:dddd}.", valentinesDay2020);
            Console.WriteLine(valentinesDay2020Format);

            Console.WriteLine("----------------------------");
            #endregion

            Console.ReadLine();
        }
    }
}
