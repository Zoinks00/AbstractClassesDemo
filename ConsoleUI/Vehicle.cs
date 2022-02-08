using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {

       

        public string Make { get; set; } = "Vehicle make";
        public string Model { get; set; } = " model";
        public int Year { get; set; } = 1930;

        public abstract void DriveAbstract();

        //virtual calling
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is in virutal drive.");
        }
    }
}
