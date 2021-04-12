using System;
using System.Collections.Generic;
using System.Text;
using InheritanceExerciseClassLibrary.Entities.Enums;

namespace InheritanceExerciseClassLibrary.Entities.Models
{
    public class Bicycle : WheeledVehicle
    {
        
        public int NumberOfSpeedLevels { get; set; }

        public bool IsElectric { get; set; } // malku mi e cudna logikata na zadacava vaka, zasto ako vekje e elektricen tocakot, ne treba da e Type NoEngine, poso bi si imal elektricen motor, ama vekje mnogu ja zaterav vaka zadacava i resiv da go ostavam vaka, pa booleanov sam da si stoi i da moze da se menuva samo toj nezavisno od TypeOfVehicle.
        public Bicycle() : base(TypeOfVehicle.NoEngine)
        {
        }

    public void Ride() 
        {
            Console.WriteLine("It's a perfect day for a bike ride, what are you waiting for?");
        }

        public override void Repair()
        {
            Console.WriteLine("Basic bike service:\n" +
                "Brake adjustment: ✓\n" +
                "Gear adjustment: ✓\n" +
                "General lubrication: ✓\n" +
                "Tyre inflation check: ✓\n" +
                "You are good to go! Have a great ride :)");
        }
    }
}
