using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    //Section 1
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "Default Year";

        public string Make { get; set; } = "Default Make";

        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() {
            Console.WriteLine("Default VIRTUAL drive method.");
                }

        //Section 2
        public virtual int HowManyWheels { get; set; } = 0;

        public virtual void PrintOtherInfo()
        {
            Console.WriteLine("Default PRINT OTHER INFO section.");
        }

    }
}
