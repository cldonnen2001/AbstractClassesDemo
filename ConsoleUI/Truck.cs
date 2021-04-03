using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Truck : Vehicle
    {
        public bool HasBallAndHitch { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"I am driving a {GetType().Name}, it is a {Model}");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
