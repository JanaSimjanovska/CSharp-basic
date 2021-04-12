using System;
using System.Collections.Generic;
using System.Text;
using InheritanceExerciseClassLibrary.Entities.Enums;

namespace InheritanceExerciseClassLibrary.Entities.Models
{
    public class WheeledVehicle : Vehicle
    {
        public int NumberOfWheels { get; set; }
        public TypeOfVehicle Type { get; set; }

        public WheeledVehicle()
        {
        }

        public WheeledVehicle(TypeOfVehicle type) : base()
        {
            Type = type;
        }

        public virtual void Repair() 
        {
            Console.WriteLine("Your vehicle is all patched up!");
        }
    }
}
