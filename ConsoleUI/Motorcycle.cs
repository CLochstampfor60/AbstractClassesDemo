using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
//Abstracts of Vehicle
        public override int Year { get; set; }

        public override string Make { get; set; }

        public override string Model { get; set; }

        public override int HowManyWheels { get; set; }

//Unique to the Motorcycle class
        public int HasSideCart { get; set; }

        public string IsDangerous { get; set; }

 // Virtual methods shared between vehicles
        public override void DriveAbstract()
        {
            /*throw new NotImplementedException();*/
            Console.WriteLine("This is DriveAbstract");
        }

        public override void DriveVirtual()
        {
            /*base.DriveVirtual();*/
           /* Console.WriteLine("This is DriveVirtual");*/
        }
    }
}
