using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    // inherant from Vehicle class
    public class Car : Vehicle
    {
        public Car()
        {
        }
        public bool OffRoad{ get; set;} = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Car is moving.");
        }
    }
}
