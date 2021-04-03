using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 03 Homework");
            Console.WriteLine("---------------------------");

            #region Task 01
            // Task 01 - Sum Of Even
            Console.WriteLine("Task 01 - Sum Of Even");

            //Make a console application called SumOfEven. Inside it create an array of 6 integers.Get numbers from the input, find and print the sum of the even numbers from the array:
            //*Test Data:
            //            *Enter integer no.1:
            //    *4
            //  * Enter integer no.1:
            //    *3
            //  * Enter integer no.1:
            //    *7
            //  * Enter integer no.1:
            //    *3
            //  * Enter integer no.1:
            //    *2
            //  * Enter integer no.1:
            //    *8
            //* Expected Output:
            //            *The result is: 14

            int[] arrayOf6Integers = new int[6];
            int sumOfEven = 0;


            for (int i = 0; i < arrayOf6Integers.Length; i++)
            {
                Console.WriteLine("Enter number:");
                bool isUserIntInputSuccess = int.TryParse(Console.ReadLine(), out int userNumber);

                if (!isUserIntInputSuccess)
                {
                    Console.WriteLine("Invalid input!\nThe rest of your input was converted to 0 by default!\nPlease enter valid numeric values next time!");
                    break;
                }
                else
                {
                    arrayOf6Integers[i] = userNumber;
                    if (arrayOf6Integers[i] % 2 == 0)
                    {
                        sumOfEven += arrayOf6Integers[i];
                    }
                }
            }

            Console.WriteLine($"The sum of the even numbers in the array is {sumOfEven}.");
            #endregion

            #region Task 02
            Console.WriteLine("---------------------------");
            Console.WriteLine("Task 02 - Student Group");

            // Task 02 - Student Group

            //            *Make a new console application called StudentGroup
            //* Make 2 arrays called studentsG1 and studentsG2 and fill them with 5 student names. 
            //*Get a number from the console between 1 and 2 and print the students from that group in the console.
            //* Ex: studentsG1["Zdravko", "Petko", "Stanko", "Branko", "Trajko"]
            //* Test Data:
            //            *Enter student group: (there are 1 and 2 )
            //    *1
            //* Expected Output:
            //            *The Students in G1 are: 
            //  *Zdravko
            //  * Petko
            //  * Stanko
            //  * Branko
            //  * Trajko

            string[] studentsG1 = new string[] { "Zdravko", "Pero", "Stanko", "Blazo", "Trajko" };
            string[] studentsG4 = new string[] { "Jana", "Nikola", "Ivan", "Sanja", "Marta" };

            Console.WriteLine("Enter 1 to get the student names from G1 and 2 to get the student names from G4:");

            bool is1Or2Success = int.TryParse(Console.ReadLine(), out int userChoice);

            if (!is1Or2Success)
                Console.WriteLine("Invalid input!");
            else
            {
                if(userChoice != 1 && userChoice != 2)
                    Console.WriteLine("Invalid input! You can choose either 1 or 2");
                else
                {
                    if(userChoice == 1)
                    {
                        Console.WriteLine("The students in G1 are:");
                        foreach (string studentName in studentsG1)
                        {
                            Console.WriteLine($"{Array.IndexOf(studentsG1, studentName) + 1}. {studentName}");
                        }                                
                    }
                    else 
                    {
                        Console.WriteLine("The students in G4 are:");
                        foreach (string studentName in studentsG4)
                        {
                            Console.WriteLine($"{Array.IndexOf(studentsG4, studentName) + 1}. {studentName}");
                        }
                    }
                }
            }
            #endregion

            Console.ReadLine();
        }
    }
}
