using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Average Number Calculator");

            //Task 2
            //Calculate Average Number

            Console.WriteLine("Enter first number: ");
            bool isUserFirstNumberSuccess = double.TryParse(Console.ReadLine(), out double userFirstNumber);
            Console.WriteLine("Enter second number: ");
            bool isUserSecondNumberSuccess = double.TryParse(Console.ReadLine(), out double userSecondNumber);
            Console.WriteLine("Enter second number: ");
            bool isUserThirdNumberSuccess = double.TryParse(Console.ReadLine(), out double userThirdNumber);
            Console.WriteLine("Enter second number: ");
            bool isUserFourthNumberSuccess = double.TryParse(Console.ReadLine(), out double userFourthNumber);
            double result;


            if (isUserFirstNumberSuccess && isUserSecondNumberSuccess && isUserThirdNumberSuccess && isUserFourthNumberSuccess)
            {
                result = (userFirstNumber + userSecondNumber + userThirdNumber + userFourthNumber) / 4;
                Console.WriteLine("The average of the four numbers you enetered is: " + result);
            }
            else
            {
                Console.WriteLine("Please make sure all of the entered values are valid numerical values!");
            }

            Console.ReadLine();
        }
    }
}
