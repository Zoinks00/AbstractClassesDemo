using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             *Complete- Create an abstract class called Vehicle
             *Complete - The vehicle class shall have three string properties Year, Make, and Model
             *Complete - Set the defaults to something generic in the Vehicle class
             *Complete - Vehicle shall have an abstract method called DriveAbstract with no implementation
             *Complete - Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             *Complete - Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Complete -Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Complete - Provide the implementations for the abstract methods
             * Complete - Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var jeep = new Car
            {
                OffRoad = true,
                Make = "Jeep",
                Model = "Grand Cherokee",
                Year = 1993

            };

            var harley = new Motorcycle
            {
                HasSideCar = true,
                Make = "Harley-Davison",
                Model = "Road King",
                Year = 1999
            };

            Vehicle fithAve = new Car { Make = "Cheysler", Model = "New Yorker", Year = 1990 };
            Vehicle mopad = new Motorcycle { HasSideCar = false, Make = "Hoopty", Model = "Push-Start", Year = 1970 };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
            

            // Call each of the drive methods for one car and one motorcycle 

            vehicles.Add(jeep);
            vehicles.Add(harley);
            vehicles.Add(fithAve);
            vehicles.Add(mopad);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"Vehicle OffRoad :Vehcile Make: {item.Make}\nVehicle Model: {item.Model}\nVehicle Year: {item.Year}");
                item.DriveAbstract();
                item.DriveVirtual();
                Console.WriteLine("\n\n");
             }

            #endregion            
            Console.ReadLine();
        }
    }
}
