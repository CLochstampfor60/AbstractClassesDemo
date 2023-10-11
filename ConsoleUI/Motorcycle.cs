using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        //Section 1
        public string Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public override void DriveAbstract() {}

        public override void DriveVirtual()
        {

            Console.WriteLine("This is the VIRTUAL MOTORCYCLE method.");
        }

        //Section 2
        public override int HowManyWheels { get; set; }

        public int HasSideCart { get; set; }

        public bool HigherRisk { get; set; }
    }
}
