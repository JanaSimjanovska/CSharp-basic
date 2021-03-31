using System;

namespace Class_02_Homework_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task 01
            Console.WriteLine("Task 01 - Simple Calculator");

            //Task 1
            //Real Calculator

            Console.WriteLine("Enter first number: ");
            bool isUserFirstNumberSuccess = double.TryParse(Console.ReadLine(), out double userFirstNumber);
            Console.WriteLine("Enter second number: ");
            bool isUserSecondNumberSuccess = double.TryParse(Console.ReadLine(), out double userSecondNumber);
            Console.WriteLine("Choose an operation (either +, -, * or /): ");
            bool isChosenOperatorSuccess = char.TryParse(Console.ReadLine(), out char chosenOperator);
            double result;


            if (isUserFirstNumberSuccess && isUserSecondNumberSuccess && isChosenOperatorSuccess)
            {
                switch (chosenOperator)
                {
                    case '+':
                        result = userFirstNumber + userSecondNumber;
                        Console.WriteLine("The result of the operation is: " + result);
                        break;
                    case '-':
                        result = userFirstNumber - userSecondNumber;
                        Console.WriteLine("The result of the operation is: " + result);
                        break;
                    case '*':
                        result = userFirstNumber * userSecondNumber;
                        Console.WriteLine("The result of the operation is: " + result);
                        break;
                    case '/':
                        result = userFirstNumber / userSecondNumber;
                        Console.WriteLine("The result of the operation is: " + result);
                        break;
                    default:
                        Console.WriteLine("Invalid operation chosen! Next time please choose either +, -, * or /!");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter valid numerical values and one of the four possible operators!");
            }
            #endregion

            #region Task 02
            Console.WriteLine("______________________________\n");
            Console.WriteLine("Average Number Calculator");

            //Task 2
            //Calculate Average Number

            Console.WriteLine("Enter first number: ");
            bool isUserFirstNumberSuccess2 = double.TryParse(Console.ReadLine(), out double userFirstNumber2);
            Console.WriteLine("Enter second number: ");
            bool isUserSecondNumberSuccess2 = double.TryParse(Console.ReadLine(), out double userSecondNumber2);
            Console.WriteLine("Enter third number: ");
            bool isUserThirdNumberSuccess2 = double.TryParse(Console.ReadLine(), out double userThirdNumber);
            Console.WriteLine("Enter fourth number: ");
            bool isUserFourthNumberSuccess2 = double.TryParse(Console.ReadLine(), out double userFourthNumber);
            double result2;


            if (isUserFirstNumberSuccess2 && isUserSecondNumberSuccess2 && isUserThirdNumberSuccess2 && isUserFourthNumberSuccess2)
            {
                result2 = (userFirstNumber2 + userSecondNumber2 + userThirdNumber + userFourthNumber) / 4;
                Console.WriteLine("The average of the four numbers you enetered is: " + result2);
            }
            else
            {
                Console.WriteLine("Please make sure all of the entered values are valid numerical values!");
            }
            #endregion

            #region Task 03
            Console.WriteLine("______________________________\n");
            Console.WriteLine("Let's swap numbers :)");

            //Task 3:
            //SwapNumbers

            Console.WriteLine("Enter first number (number should be an integer): ");
            bool isUserFirstNumberSuccess3 = int.TryParse(Console.ReadLine(), out int userFirstNumber3);
            Console.WriteLine("Enter second number (number should be an integer): ");
            bool isUserSecondNumberSuccess3 = int.TryParse(Console.ReadLine(), out int userSecondNumber3);

            Console.WriteLine(userFirstNumber3);
            Console.WriteLine(userSecondNumber3);

            int tempVar = userFirstNumber3;
            userFirstNumber3 = userSecondNumber3;
            userSecondNumber3 = tempVar;


            if (isUserFirstNumberSuccess3 && isUserSecondNumberSuccess3)
            {
                Console.WriteLine("First number: " + userFirstNumber3 + "\nSecond number: " + userSecondNumber3);
            }
            else
            {
                Console.WriteLine("Please enter valid integers!");
            }
            #endregion

            #region Task 04
            Console.WriteLine("______________________________\n");
            Console.WriteLine("Tik-tak, tik-tak...");

            //Task 4:
           
            Console.WriteLine("Enter a number: ");
            bool isUserNumberSuccess = double.TryParse(Console.ReadLine(), out double userNumber);


            if (isUserNumberSuccess)
            {
                if (userNumber % 3 == 0)
                {
                    if (userNumber % 5 == 0)
                    {
                        Console.WriteLine("Tik - Tak");
                    }
                    else
                    {
                        Console.WriteLine("Tik");
                    }

                }
                else if (userNumber % 5 == 0)
                {
                    Console.WriteLine("Tak");
                }
                else
                {
                    Console.WriteLine("Bad number");
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer!");
            }
            #endregion

            Console.ReadLine();
        }
    }
}
