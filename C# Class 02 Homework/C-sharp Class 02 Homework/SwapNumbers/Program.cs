using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's swap numbers :)");

            //Task 3:
            //SwapNumbers

            Console.WriteLine("Enter first number (number should be an integer): ");
            bool isUserFirstNumberSuccess = int.TryParse(Console.ReadLine(), out int userFirstNumber);
            Console.WriteLine("Enter second number (number should be an integer): ");
            bool isUserSecondNumberSuccess = int.TryParse(Console.ReadLine(), out int userSecondNumber);

            Console.WriteLine(userFirstNumber);
            Console.WriteLine(userSecondNumber);

            int tempVar1 = userFirstNumber;
            int tempVar2 = userSecondNumber;

            userFirstNumber = tempVar2;
            userSecondNumber = tempVar1;


            if(isUserFirstNumberSuccess && isUserSecondNumberSuccess)
            {
                Console.WriteLine("First number: " + userFirstNumber + " \r\nSecond number: " + userSecondNumber);
            }
            else
            {
                Console.WriteLine("Please enter valid integers!");
            }

            Console.ReadLine();
        }
    }
}
