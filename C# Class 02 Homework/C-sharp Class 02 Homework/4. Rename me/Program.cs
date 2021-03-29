using System;

namespace _4._Rename_me
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tik-tak, tik-tak...");

            //Task 4:
            //Write a program, where for a given number entered via the keyboard, it will print:


            //"Tik" if divisible by 3,
            //"Tak" if divisible by 5,
            //"Tik - Tak" if divisible by 3 and 5.
            //If the number is not divisible by 3 or 5, then print "Bad number".

            Console.WriteLine("Enter a number: ");
            bool isUserNumberSuccess = double.TryParse(Console.ReadLine(), out double userNumber);

            if (isUserNumberSuccess)
            {
                if(userNumber % 3 == 0)
                {
                    if(userNumber % 5 == 0)
                    {
                        Console.WriteLine("Tik - Tak");
                    }
                    else
                    {
                        Console.WriteLine("Tik");
                    }
                    
                }
                else if(userNumber % 5 == 0)
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

            Console.ReadLine();
        }
    }
}
