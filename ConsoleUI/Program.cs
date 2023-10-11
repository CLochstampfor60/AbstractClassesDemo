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
             * DONE: Create an abstract class called Vehicle
             * DONE: The vehicle class shall have three string properties Year, Make, and Model
             * DONE: Set the defaults to something generic in the Vehicle class
             * DONE: Vehicle shall have an abstract method called DriveAbstract with no implementation
             * DONE: Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * DONE: Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * DONE: Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * DONE: Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */
            var car1 = new Car()
            {
                Make = "Pontiac",
                Model = "Vibe",
                Year = "2009",
                HasTrunk = true,
                NumberOfSeatbelts = 4,
                HowManyWheels = 4,
            };
            var motorcycle1 = new Motorcycle
            {
                Make = "Honda",
                Model = "SCL500",
                Year = "2023",
                HasSideCart = false,
                HigherRisk = true,
                HowManyWheels = 2,
            };
            Vehicle vehicle1 = new Car()
            {
                Make = "Honda",
                Model = "Accord",
                Year = "2023",
                HasTrunk = true,
                NumberOfSeatbelts = 4,
                HowManyWheels = 4,
            };
            Vehicle vehicle2 = new Motorcycle()
            {
                Make = "Indian",
                Model = "Chieftain Elite",
                Year = "2023",
                HasSideCart = false,
                HigherRisk = true,
                HowManyWheels = 2,
            };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            // Call each of the drive methods for one car and one motorcycle
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Year: {vehicle.Year}");
                Console.WriteLine($"Wheel Count: {vehicle.HowManyWheels}");

                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
                Console.WriteLine("---------------");
                Console.WriteLine();
            }

            #endregion            
    
        }
    }
}
