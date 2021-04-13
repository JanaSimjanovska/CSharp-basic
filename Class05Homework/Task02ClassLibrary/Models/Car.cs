using System;
using System.Collections.Generic;
using System.Text;

namespace Task02ClassLibrary.Models
{
    public class Car
    {
        public Driver Driver { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }

        public Car()
        {
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed(Driver driver)
        {
            return Speed * driver.Skill;
        }
    }
}
