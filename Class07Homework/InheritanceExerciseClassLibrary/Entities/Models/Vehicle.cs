using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExerciseClassLibrary.Entities.Models
{
    public class Vehicle
    {
        public int ID { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }

        public Vehicle()
        {
        }

        public void PrintInfo() 
        {
            Console.WriteLine($"Vehicle ID: {ID}\n" +
                $"Manufacturer: {Manufacturer}\n" +
                $"Model: {Model}");
        }
    }
}
