using System;

namespace Homework_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Calculator");

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
                Console.WriteLine("Please enter valid numerical values");
            }

            Console.ReadLine();
        }
    }
}
