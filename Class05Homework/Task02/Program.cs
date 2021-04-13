using System;
using Task02ClassLibrary.Models;
using Task02ServiceClass;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 05 Homework");
            Console.WriteLine("----------------------------");

            #region Task 02

            Console.WriteLine("Task 02");

            // ## Task 2
            // * Make a class Driver. Add properties: Name, Skill
            // * Make a class Car. Add properties: Model, Speed and Driver
            // * Make a method of the Car class called : CalculateSpeed() that takes a driver object and calculates the skill multiplied by the speed of the car and return it as a result.
            // * Make a method RaceCars() that will get two Car objects that will determine which car will win and print the result in the console.
            // * Make 4 car objects and 4 driver objects.
            // * Ask the user to select a two cars and two drivers for the cars. Add the drivers to the cars and call the RaceCars() methods
            // * Test Data:
            //  * Choose a car no.1: 
            //    * Hyundai
            //    * Mazda
            //    * Ferrari
            //    * Porsche
            //  * Choose Driver:
            //    * Bob
            //    * Greg
            //    * Jill
            //    * Anne
            //  * Choose a car no.2:
            //    * Hyundai
            //    * Mazda
            //    * Ferrari
            //    * Porsche
            //  * Choose Driver:
            //    * Bob
            //    * Greg
            //    * Jill
            //    * Anne
            //* Expected Output:
            //  * Car no. 2 was faster.

            //> **BONUS 1**: If a user chooses option one for the first car, eliminate that option when the user picks car two.

            //> **BONUS 2**: Make the Output message say what was the model of the car that won, what speed was it going and which driver was driving it.

            //> **BONUS 3**: Implement a Race Again Feature where you ask the user if he wants to race again and repeat the racing function.


            Driver bob = new Driver("Bob", 1);
            Driver greg = new Driver("Greg", 4);
            Driver jill = new Driver("Jill", 3);
            Driver anne = new Driver("Anne", 2);

            Driver[] drivers = new Driver[]
            {
                bob,
                greg,
                jill,
                anne
            };

            Car hyundai = new Car("Hyundai", 280);
            Car mazda = new Car("Mazda", 240);
            Car ferrari = new Car("Ferrari", 330);
            Car porsche = new Car("Porsche", 340);

            Car[] cars = new Car[]
            {
                hyundai,
                mazda,
                ferrari,
                porsche
            };

            string yesOrNo = "";

            
            do
            {
                string[] chosenCarsAndDrivers = Task02Methods.GetCarsAndDrivers(cars, drivers);

                Car[] carObjectsToRace = Task02Methods.AssignDriverToCarObject(cars, drivers, chosenCarsAndDrivers);

                Task02Methods.RaceCars(carObjectsToRace[0], carObjectsToRace[1]);

                Console.WriteLine("Do you wanna race again? Press Y if you do, and any key to exit the game.");

                yesOrNo = Console.ReadLine().ToLower();
                while (yesOrNo != "y" && yesOrNo != "n")
                {
                    Console.WriteLine($"Please choose \"Y\" to race again, and \"N\" to exit!");
                    yesOrNo = Console.ReadLine().ToLower();
                }
            }
            while (yesOrNo == "y");
            

            

           
            
            Console.WriteLine("----------------------------");
            #endregion

            Console.ReadLine();
        }
    }
}
