using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        //Section 1
        public override void DriveAbstract() 
        {
            Console.WriteLine("The car is driveable. It provides a smooth and safe experience for the driver.");
        }

        public virtual void DriveVirtual()
        {
            base.DriveVirtual();
           
        }

        //Section 2
        public override int HowManyWheels { get; set; }

        public int NumberOfSeatbelts { get; set; }

        public bool HasTrunk { get; set; }
    }
}
