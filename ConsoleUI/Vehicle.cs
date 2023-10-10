using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public Vehicle() { }

        public abstract int Year { get; set; }
  
       public abstract string Make { get; set; }
  
        public abstract string Model { get; set; }

        public virtual int HowManyWheels {  get; set; }

        public abstract void DriveAbstract();
        public virtual void DriveVirtual() {
            Console.WriteLine(DateTime.Now);
                }

    }
}
