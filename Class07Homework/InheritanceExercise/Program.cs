using System;
using InheritanceExerciseClassLibrary.Entities.Enums;
using InheritanceExerciseClassLibrary.Entities.Models;


namespace InheritanceExercise


{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class 07 Homework - Inheritance");

            #region Unicycle

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            WheeledVehicle unicycle = new WheeledVehicle();
            unicycle.ID = 272;
            unicycle.Model = "Flat Top Unicycle";
            unicycle.Manufacturer = "Sun Bicycles";
            unicycle.NumberOfWheels = 1;
            unicycle.Type = TypeOfVehicle.Engine;
            unicycle.PrintInfo();
            unicycle.Repair();

            #endregion


            #region Petrol Car

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            Car petrolCar = new Car();
            petrolCar.EngineType = TypeOfEngine.Petrol;
            petrolCar.ID = 55;
            petrolCar.Manufacturer = "Zastava Automobiles";
            petrolCar.Model = "Yugo";
            petrolCar.PrintInfo();
            petrolCar.NumberOfDoors = 3;
            petrolCar.NumberOfWheels = 4;
            petrolCar.FuelConsumption = 8;
            Console.WriteLine($"The {petrolCar.Model}'s fuel consumption of {petrolCar.FuelConsumption}litres/100km.");
            Console.WriteLine($"The {petrolCar.Model} has {petrolCar.NumberOfDoors} doors.");
            Console.WriteLine($"The {petrolCar.Model} has {petrolCar.NumberOfWheels} wheels.");
            Console.WriteLine($"The {petrolCar.Model} has a {petrolCar.EngineType} engine.");
            petrolCar.Drive();
            petrolCar.Repair();

            #endregion


            #region Diesel Car
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            Car dieselCar = new Car();
            dieselCar.EngineType = TypeOfEngine.Diesel;
            dieselCar.ID = 95;
            dieselCar.Manufacturer = "BMW";
            dieselCar.Model = "520d";
            dieselCar.PrintInfo();
            dieselCar.NumberOfDoors = 5;
            dieselCar.NumberOfWheels = 4;
            dieselCar.FuelConsumption = 4;
            Console.WriteLine($"The {dieselCar.Model}'s fuel consumption of {dieselCar.FuelConsumption}litres/100km.");
            Console.WriteLine($"The {dieselCar.Model} has {dieselCar.NumberOfDoors} doors.");
            Console.WriteLine($"The {dieselCar.Model} has {dieselCar.NumberOfWheels} wheels.");
            Console.WriteLine($"The {dieselCar.Model} has a {dieselCar.EngineType} engine.");
            dieselCar.Drive();
            dieselCar.Repair();
            #endregion


            #region Electric Car

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            ElectricCar electricCar = new ElectricCar(TypeOfEngine.Electric);
            electricCar.ID = 23;
            electricCar.Model = "Model S";
            electricCar.Manufacturer = "Tesla";
            electricCar.PrintInfo();
            electricCar.NumberOfWheels = 4;
            electricCar.NumberOfDoors = 3;
            Console.WriteLine($"The {electricCar.Model} has {electricCar.NumberOfDoors} doors.");
            Console.WriteLine($"The {electricCar.Model} has {electricCar.NumberOfWheels} wheels.");
            electricCar.SwitchToBatteryOrCombustionEngine();
            electricCar.MaxSpeed = 220;
            electricCar.Repair();
            Console.WriteLine($"Current battery percentage: {electricCar.BatteryPercentage}%.");
            electricCar.Recharge();
            electricCar.Drive();
            Console.WriteLine($"Current battery percentage: {electricCar.BatteryPercentage}%.");

            #endregion


            #region Hybrid Car

            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            ElectricCar hybridCar = new ElectricCar(TypeOfEngine.Hybrid);
            hybridCar.ID = 34;
            hybridCar.Model = "Yaris Hybrid";
            hybridCar.Manufacturer = "Toyota";
            hybridCar.PrintInfo();
            hybridCar.NumberOfWheels = 4;
            hybridCar.NumberOfDoors = 5;
            hybridCar.FuelConsumption = 9;
            Console.WriteLine($"The {hybridCar.Model}'s fuel consumption of {hybridCar.FuelConsumption}litres/100km.");
            Console.WriteLine($"The {hybridCar.Model} has {hybridCar.NumberOfDoors} doors.");
            Console.WriteLine($"The {hybridCar.Model} has {hybridCar.NumberOfWheels} wheels.");
            hybridCar.SwitchToBatteryOrCombustionEngine();
            hybridCar.MaxSpeed = 165;
            hybridCar.Repair();
            Console.WriteLine($"Current battery percentage: {hybridCar.BatteryPercentage}%.");
            hybridCar.Recharge();
            hybridCar.Drive();
            Console.WriteLine($"Current battery percentage: {hybridCar.BatteryPercentage}%.");

            #endregion


            #region Bicycle
            Console.WriteLine("----------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------");
            Bicycle bicycle = new Bicycle();
            bicycle.ID = 775;
            bicycle.Model = "MYKA hybrid mtb/city bicycle";
            bicycle.Manufacturer = "Specialized";
            bicycle.PrintInfo();
            bicycle.NumberOfSpeedLevels = 21;
            bicycle.NumberOfWheels = 2;
            bicycle.IsElectric = true;
            Console.WriteLine(bicycle.IsElectric);
            bicycle.Repair();
            bicycle.Ride();

            #endregion

            Console.ReadLine();
        }
    }
}
