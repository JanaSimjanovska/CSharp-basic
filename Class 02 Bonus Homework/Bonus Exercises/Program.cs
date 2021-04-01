using System;

namespace Bonus_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 02 Bonus Exercises");
            Console.WriteLine("_____________________________________\n");

            #region Exercise 01
            // Exercise 01
            // Write a program that will generate an appropriate grade for the entered number of exam points according to the following table:
            // Points     Grade
            // 0 - 50     5
            // 51 - 60    6
            // 61 - 70    7
            // 71 = 80    8
            // 81 - 90    9
            // 91 - 100   10

            Console.WriteLine("Exercise 1");
            Console.WriteLine("Enter a number of points:");

            int grade = 0;
            bool isPointsSuccess = int.TryParse(Console.ReadLine(), out int points);


            if (isPointsSuccess)
            {
                if (points < 0 || points > 100)
                {
                    Console.WriteLine("Please enter a number from 0 to 100!");
                }
                else
                {
                    if (points >= 0 && points <= 50)
                    {
                        grade = 5;
                    }
                    else if (points >= 51 && points <= 60)
                    {
                        grade = 6;
                    }
                    else if (points >= 61 && points <= 70)
                    {
                        grade = 7;
                    }
                    else if (points >= 71 && points <= 80)
                    {
                        grade = 8;
                    }
                    else if (points >= 81 && points <= 90)
                    {
                        grade = 9;
                    }
                    else if (points >= 91 && points <= 100)
                    {
                        grade = 10;
                    }
                    Console.WriteLine("Your grade is: " + grade);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid numeric value!");
            }
            #endregion

            #region Exercise 02
            // Exercise 02
            // Change the previous program so that in addition to the grades, the + and - signs will be printed depending on the value of the last digit of the points:
            // Points        print           Ex:
            // 1 - 3           +           81 = 9-
            // 4 - 7     (empty space)     94 = 10
            // 8 - 0           -           68 = 7+

            Console.WriteLine("_____________________________________\n");
            Console.WriteLine("Exercise 2");
            Console.WriteLine("Enter a number of points:");

            bool isPointsEx2Success = int.TryParse(Console.ReadLine(), out int points2);
            int grade2 = 0;

            if (isPointsEx2Success)
            {
                if (points2 < 0 || points2 > 100)
                {
                    Console.WriteLine("Please enter a number from 0 to 100!");
                }
                else
                {
                    if (points2 >= 0 && points2 <= 50)
                    {
                        grade2 = 5;
                    }
                    else if (points2 >= 51 && points2 <= 60)
                    {
                        grade2 = 6;
                    }
                    else if (points2 >= 61 && points2 <= 70)
                    {
                        grade2 = 7;
                    }
                    else if (points2 >= 71 && points2 <= 80)
                    {
                        grade2 = 8;
                    }
                    else if (points2 >= 81 && points2 <= 90)
                    {
                        grade2 = 9;
                    }
                    else if (points2 >= 91 && points2 <= 100)
                    {
                        grade2 = 10;
                    }

                    if (points2 % 10 >= 1 && points2 % 10 <= 3)
                    {
                        Console.WriteLine("here");
                        Console.WriteLine("Your grade is: " + grade2 + "-");
                    }
                    else if (points2 % 10 >= 8 || points2 % 10 == 0)
                    {
                        Console.WriteLine("Your grade is: " + grade2 + "+");
                    }
                    else
                    {
                        Console.WriteLine("Your grade is: " + grade2);
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid numeric value!");
            }
            #endregion

            #region Exercise 03
            // Exercise 03
            // Write a program where a seven-digit number is entered from the keyboard. The program prints YES if the number is special and NO otherwise. A number is special if it is divisible by its first digit, and its not divisible by the sum of the last two. Beware of dividing with zero, print an "Invalid number!" message in such a case.

            Console.WriteLine("_____________________________________\n");
            Console.WriteLine("Exercise 3");
            Console.WriteLine("Enter a seven-digit number to check if it is special:");

            bool is7DigitNumSuccess = int.TryParse(Console.ReadLine(), out int sevenDigitNum);
            string checkNumLength = sevenDigitNum.ToString();


            if (is7DigitNumSuccess)
            {
                if (checkNumLength.Length != 7)
                {
                    Console.WriteLine("Please enter a seven-digit integer!");
                }
                else
                {
                    int firstDigit = int.Parse(checkNumLength.Substring(0, 1));
                    int sixthDigit = int.Parse(checkNumLength.Substring(5, 1));
                    int seventhDigit = int.Parse(checkNumLength.Substring(6, 1));

                    if (sixthDigit + seventhDigit == 0)
                    {
                        Console.WriteLine("Invalid number!");
                    }
                    else if (sevenDigitNum % firstDigit == 0 && sevenDigitNum % (sixthDigit + seventhDigit) == 0)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid numeric value!");
            }
            #endregion

            #region Exercise 04
            // Exercise 04
            // Create a program that for a given date from standard input (in DD MM GGGG format) will print YES or NO message on standard output depending on whether the entered date is correct or not. When determining the validity of the date, all factors should be taken into account: whether the month is a number between 1 and 12, whether the day corresponds to the number of days in that month. If it is 29.02, be careful if it is a leap year. A leap year is any year that is divisible by 400 or divisible by 4, but not by 100.

            Console.WriteLine("_____________________________________\n");
            Console.WriteLine("Exercise 4");
            Console.WriteLine("Enter day, month and year to check if it is a valid date:");
            Console.WriteLine("Enter day (1 - 31):");
            bool isDayInputSuccess = int.TryParse(Console.ReadLine(), out int day);
            Console.WriteLine("Enter month (1 - 12):");
            bool isMonthInputSuccess = int.TryParse(Console.ReadLine(), out int month);
            Console.WriteLine("Enter year:");
            bool isYearInputSuccess = int.TryParse(Console.ReadLine(), out int year);


            if (isDayInputSuccess && isMonthInputSuccess && isYearInputSuccess)
            {
                if (month >= 1 && month <= 12 && day >= 1 && day <= 31)
                {
                    if (month == 4 || month == 6 || month == 9 || month == 11)
                    {
                        if (day == 31)
                        {
                            Console.WriteLine("The date isn't valid because the month you entered can't have more than 30 days! Try again.");
                        }
                        else
                        {
                            Console.WriteLine("YES");
                        }
                    }
                    else if (month == 2)
                    {
                        if (day == 30 || day == 31)
                        {
                            Console.WriteLine("The date isn't valid because february can have either 28 or 29 days! Try again.");
                        }
                        else if (day == 29)
                        {
                            if ((year % 400 == 0 || year % 4 == 0) && year % 100 != 0)
                            {

                                Console.WriteLine("YES");
                            }
                            else
                            {
                                Console.WriteLine("The date isn't valid because february can only have 29 days on a leap year and the year you entered isn't one! Try again.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("YES");
                        }
                    }
                    else
                    {
                        Console.WriteLine("YES");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a numerical value from 1 to 12 for month and/or from 1 to 31 for days!");
                }
            }
            else
            {
                Console.WriteLine("Please enter valid values for day, month and year!");
            }
            #endregion

            #region Exercise 05
            // Exercise 05
            //In a company all employees use one centralized system, for which an account has been created.Username to each employee is generated according to the ID of the employee, using the first digits that give the date of birth will be taken and the value will be calculated: day * 100 + month * 1000 + year So if the part of the ID number that gives the date is 1103998, then we get 11 * 100 + 3 * 1000 + 1998 = 6098. If the number that will be obtained after the calculation is five digits, then it is the username. Otherwise, if it is four digits, then the first digit is added to be:
            //7 - if the year of birth is up to 1960
            //8 - if the year of birth is between 1961 - 1980
            //9 - if the year of birth is between 1981 - 1999
            //Note: All employees are considered to have been born before 1999.

            Console.WriteLine("_____________________________________\n");
            Console.WriteLine("Exercise 5");

            Console.WriteLine("Enter the required data in order to let us generate your username;");
            Console.WriteLine("Enter date:");
            bool isDateSuccess = int.TryParse(Console.ReadLine(), out int day1);
            Console.WriteLine("Enter month:");
            bool isMonthSuccess = int.TryParse(Console.ReadLine(), out int month1);
            Console.WriteLine("Enter year:");
            bool isYearSuccess = int.TryParse(Console.ReadLine(), out int year1);
            int userName;
            string userNameString = "";


            if (!isDateSuccess || !isMonthSuccess || !isYearSuccess)
            {
                Console.WriteLine("Please enter valid day, month and year for your date of birth!");
            }
            else
            {
                if (day1 < 1 || day1 > 31)
                {
                    Console.WriteLine("Please enter a number from 1 - 31 for your day of birth!");
                }
                else if (month1 < 1 || month1 > 12)
                {
                    Console.WriteLine("Please enter a number from 1 - 12 for your month of birth!");
                }
                else if (year1.ToString().Length != 4 || year1 > 1999)
                {
                    Console.WriteLine("Please enter a valid birth year (it has to have 4 digits and be less than 2000)!");
                }
                else
                {
                    userName = day1 * 100 + month1 * 1000 + year1;
                    if (userName.ToString().Length == 4)
                    {
                        if (year1 <= 1960)
                        {
                            userNameString = "7" + userName.ToString();
                        }
                        else if (year1 >= 1961 && year1 <= 1980)
                        {
                            userNameString = "8" + userName.ToString();
                        }
                        else if (year1 >= 1981 && year1 <= 1999)
                        {
                            userNameString = "9" + userName.ToString();
                        }
                    }
                    else if (userName.ToString().Length == 5)
                    {
                        userNameString = userName.ToString();
                    }
                    Console.WriteLine("Your new username is: " + userNameString);
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
