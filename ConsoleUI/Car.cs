using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    /* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle                         this is done line 13
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle  this is done line 15 & 16
            * Provide the implementations for the abstract methods                                                     this is done ine 18
            * Only in the Motorcycle class will you override the virtual drive method
           */
    public class Car : Vehicle
    {
        public bool HasTrunk { get; set; }    //property - no scope/body, can not take arguements (no if else statements)
        public bool HasGoodMileage { get; set; }  // get = read, set = write

        public override void DriveAbstract()  // method, (better at returning value) express things that change the state of object, or expetation - not reproducable, use once
        {
            Console.WriteLine($"I am driving a {GetType().Name}, it is a {Model}");
        }

        public override void DriveVirtual()
        {
            base.DriveVirtual();
        }
    }
}
