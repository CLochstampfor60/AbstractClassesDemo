using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Car : Vehicle
    {
        public string Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public override void DriveAbstract() { }

        public virtual void DriveVirtual()
        {
            base.DriveVirtual();
           
        }

        public override int HowManyWheels { get; set; }

        public int NumberOfSeatbelts { get; set; }

        public bool HasTrunk { get; set; }
    }
}
