using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
   public class Motorcycle: Vehicle
    {

        public Motorcycle()
        {
        }
        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("Motorcycle is moving.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtual moving.");
        }
    }
}
