using InheritanceExerciseClassLibrary.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;


namespace InheritanceExerciseClassLibrary.Entities.Models
{
    public class Car : WheeledVehicle
    {
        public TypeOfEngine EngineType { get; set; }
        public int FuelConsumption { get; set; }
        public int NumberOfDoors { get; set; }
        public int MaxSpeed { get; set; }
        public Car() : base(TypeOfVehicle.Engine)
        {
        }
     

        public virtual void Drive() 
        {
            Console.WriteLine($"The {Model} is driving.");
        }

        public override void Repair()
        {
            Console.WriteLine("Your car needs a repair AGAIN, and it's not gonna be cheap. Sorry, no shopping for you this month :(.");
        }
    }
}
