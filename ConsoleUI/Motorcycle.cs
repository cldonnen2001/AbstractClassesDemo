using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{

    /* 
                * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
                * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
                * Provide the implementations for the abstract methods
                * Only in the Motorcycle class will you override the virtual drive method
               */
    public class Motorcycle : Vehicle
    {
        public bool HasSideCart { get; set; }  // property
        public bool HasSaddleBags { get; set; }

        public override void DriveAbstract()  // method
        {
            Console.WriteLine($"I am driving a {GetType().Name}, it is a {Model}");
        }
        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }

    }
}
