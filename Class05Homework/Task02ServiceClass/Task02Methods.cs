using System;
using System.Collections.Generic;
using System.Text;
using Task02ClassLibrary.Models;

namespace Task02ServiceClass
{
    public static class Task02Methods
    {
        public static string[] GetCarsAndDrivers(Car[] cars, Driver[] drivers)
        {
            string[] chosenCarsAndDrivers = new string[4];
            Console.WriteLine("Let's race!!!");

            #region Car 01 User Input

            // Lets user choose one of the offered cars

            Console.WriteLine("Choose car no.1:");

            foreach (Car car in cars)
            {
                Console.WriteLine($"*{car.Model}");
            }

            string userChoiceCar01 = Console.ReadLine().ToLower();

            while (userChoiceCar01 != "mazda" && userChoiceCar01 != "hyundai" && userChoiceCar01 != "porsche" && userChoiceCar01 != "ferrari")
            {
                Console.WriteLine("Please choose one of the offered options!");
                foreach (Car car in cars)
                {
                    Console.WriteLine($"*{car.Model}");
                }
                userChoiceCar01 = Console.ReadLine().ToLower();
            }

            chosenCarsAndDrivers[0] = userChoiceCar01;
            #endregion


            #region Driver 01 User Input

            // Lets user choose one of the offered drivers

            Console.WriteLine("Choose driver no.1:");

            foreach (Driver driver in drivers)
            {
                Console.WriteLine($"*{driver.Name}");
            }

            string userChoiceDriver01 = Console.ReadLine().ToLower();

            while (userChoiceDriver01 != "greg" && userChoiceDriver01 != "bob" && userChoiceDriver01 != "jill" && userChoiceDriver01 != "anne")
            {
                Console.WriteLine("Please choose one of the offered options!");
                foreach (Driver driver in drivers)
                {
                    Console.WriteLine($"*{driver.Name}");
                }
                userChoiceDriver01 = Console.ReadLine().ToLower();
            }

            chosenCarsAndDrivers[1] = userChoiceDriver01;
            #endregion


            #region Car 02 User Input

            // Lets user choose one of the offered cars, but eliminates the first chosen car from the offered options

            Console.WriteLine("Choose car no.2:");

            foreach (Car car in cars)
            {
                if (car.Model.ToLower() == userChoiceCar01)
                    continue;
                Console.WriteLine($"*{car.Model}");
            }

            string userChoiceCar02 = Console.ReadLine().ToLower();


            while (userChoiceCar02 == userChoiceCar01 || userChoiceCar02 != "mazda" && userChoiceCar02 != "hyundai" && userChoiceCar02 != "porsche" && userChoiceCar02 != "ferrari")
            {
                if (userChoiceCar02 == userChoiceCar01)
                    Console.WriteLine("The second car must be different from the first car!");

                Console.WriteLine("Please choose one of the offered options!");

                foreach (Car car in cars)
                {
                    if (car.Model.ToLower() == userChoiceCar01)
                        continue;
                    Console.WriteLine($"*{car.Model}");
                }
                userChoiceCar02 = Console.ReadLine().ToLower();
            }

            chosenCarsAndDrivers[2] = userChoiceCar02;
            #endregion


            #region Driver 02 User Input

            // Lets user choose one of the offered drivers, but eliminates the first chosen driver from the offered options
            Console.WriteLine("Choose driver no.2:");

            foreach (Driver driver in drivers)
            {
                if (driver.Name.ToLower() == userChoiceDriver01)
                    continue;
                Console.WriteLine($"*{driver.Name}");
            }

            string userChoiceDriver02 = Console.ReadLine().ToLower();


            while (userChoiceDriver02 == userChoiceDriver01 || userChoiceDriver02 != "bob" && userChoiceDriver02 != "jill" && userChoiceDriver02 != "greg" && userChoiceDriver02 != "anne")
            {
                if (userChoiceDriver02 == userChoiceDriver01)
                    Console.WriteLine("The second driver must be different from the first driver!");

                Console.WriteLine("Please choose one of the offered options!");

                foreach (Driver driver in drivers)
                {
                    if (driver.Name.ToLower() == userChoiceDriver01)
                        continue;
                    Console.WriteLine($"*{driver.Name}");
                }
                userChoiceDriver02 = Console.ReadLine().ToLower();
            }

            chosenCarsAndDrivers[3] = userChoiceDriver02;
            #endregion


            return chosenCarsAndDrivers;
        }


        public static Car[] AssignDriverToCarObject(Car[] cars, Driver[] drivers, string[] chosenCarsAndDrivers)
        {
            Car userCarChoice01 = new Car();
            Car userCarChoice02 = new Car();

            foreach (Car car in cars)
            {
                if (chosenCarsAndDrivers[0] == car.Model.ToLower())
                {
                    foreach (Driver driver in drivers)
                    {
                        if (chosenCarsAndDrivers[1] == driver.Name.ToLower())
                        {
                            car.Driver = driver;
                            userCarChoice01 = car;
                        }

                    }
                }

                if (chosenCarsAndDrivers[2] == car.Model.ToLower())
                {
                    foreach (Driver driver in drivers)
                    {
                        if (chosenCarsAndDrivers[3] == driver.Name.ToLower())
                        {
                            car.Driver = driver;
                            userCarChoice02 = car;
                        }
                    }
                }
            }

            Car[] arrayOfChosenCarObjects = new Car[] { userCarChoice01, userCarChoice02 };

            return arrayOfChosenCarObjects;
        }

        public static void RaceCars(Car car01, Car car02)
        {
            if (car01.CalculateSpeed(car01.Driver) > car02.CalculateSpeed(car02.Driver))
            {
                Console.WriteLine($"Car 01 was faster and won the race.");
                Console.WriteLine($"Model of the car that won the race: {car01.Model};\n" +
                   $"The maximum speed it was going at was {car01.Speed}km/h.\n" +
                   $"The driver of the car that won the race was {car01.Driver.Name}.");
            }
               
            else if (car01.CalculateSpeed(car01.Driver) < car02.CalculateSpeed(car02.Driver))
            {
                Console.WriteLine($"Car 02 was faster and won the race.");
                Console.WriteLine($"Model of the car that won the race: {car02.Model};\n" +
                    $"The maximum speed it was going at was {car02.Speed}km/h.\n" +
                    $"The driver of the car that won the race was {car02.Driver.Name}.");
            }
                
            else
                Console.WriteLine("Dead heat! The race was a tie!");



        }
    }
}
