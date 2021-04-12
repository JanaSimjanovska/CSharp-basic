using System;
using System.Collections;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 03 Bonus Homework");


            #region Task 01
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task 01");
            // 1. Write a program to calculate the sum of all two - digit pairs
            // numbers. The resulting amount is printed on a screen.

            int sumOfAll2DigitNums = 0;
            for (int i = 10; i < 100; i++)
                sumOfAll2DigitNums += i;

            Console.WriteLine($"The sum of all two-digit numbers is {sumOfAll2DigitNums}.");
            #endregion


            #region Task 02
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task 02");
            //2.Write a program to calculate the sum of all odd
            //two - digit numbers.The program prints the amount on the screen in the
            //format: 11 + 13 + 15 + 17 + ... +97 + 99 = 2475

            string resultString = "";
            int sumOfAllOdd2DigitNums = 0;
            for (int i = 11; i < 100; i += 2)
            {
                sumOfAllOdd2DigitNums += i;
                if (i == 99)
                    resultString += $"{i} = {sumOfAllOdd2DigitNums}.";
                else
                    resultString += $"{i} + ";
            }


            Console.WriteLine(resultString);
            #endregion


            #region Task 03

            Console.WriteLine("------------------------------");
            Console.WriteLine("Task 03");
            //3.Write a program to calculate y = x ^ n

            //Sakav da ja napravam da raboti i so vneseni decimalni broevi za stepenot, megjutoa vaka kako sto mi e postaveno resenieto, odnosno so loop ne moze, bidejkji loop-ot vrti samo cel broj pati, a jas go koristam stepenot kako brojac i bidejkji zadacata bara resenie so loop, mora vaka
            Console.WriteLine("Enter a number for x:");
            bool isXSuccess = double.TryParse(Console.ReadLine(), out double x);
            Console.WriteLine("Enter an integer for n:");
            bool isYSuccess = int.TryParse(Console.ReadLine(), out int n);
            double xToThePowerOfN = 1; // Prvo ja imav namesteno na 0, pa se cudev edno minuta vreme zaso ne mi raboti zadacata hahahah
            

            while (!isXSuccess || !isYSuccess)
            {
                Console.WriteLine("Please enter valid numerical values!");
                Console.WriteLine("Enter a number for x:");
                isXSuccess = double.TryParse(Console.ReadLine(), out x);
                Console.WriteLine("Enter an integer for n:");
                isYSuccess = int.TryParse(Console.ReadLine(), out n);
            }

            for (int i = 0; i < System.Math.Abs(n); i++)
            {
                if (n == 0)
                    xToThePowerOfN = 1;

                else
                    xToThePowerOfN *= x;
            }
            if (n < 0)
                Console.WriteLine($"{x} to the power of {n} is {1 / xToThePowerOfN}.");
            else
                Console.WriteLine($"{x} to the power of {n} is {xToThePowerOfN}.");

            #endregion


            #region Task 04
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task 04");
            //4.Write a program that will determine from n numbers(entered from the keyboard)
            //the number of numbers that are divisible by 3, when divided by 3 have a remainder of 1,
            //when divided by 3 have a remainder of 2.

            // Najdi nacin na sekoe sekoj input da go validiras deka e broj!!!
            string input = "";
            ArrayList arrOfInput = new ArrayList();

            Console.WriteLine("Enter a number: ");
            input = Console.ReadLine();
            while(input != "")
            {
                arrOfInput.Add(input);
                Console.WriteLine("Enter another number or press Enter to stop entering numbers");
                input = Console.ReadLine();
           
            }

            foreach (string item in arrOfInput)
            {
                Console.WriteLine(item);
            }

            #endregion


            #region Task 05
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task 05");

            #endregion


            #region Task 06
            Console.WriteLine("------------------------------");
            Console.WriteLine("Task 06");

            #endregion

            Console.ReadLine();
        }
    }
}
