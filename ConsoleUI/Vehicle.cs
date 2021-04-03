using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class                            ???????
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */
    public abstract class Vehicle
    {
        public int NumberOfTires { get; set; } = 1;  // = means assigning a default value //  this is a property
        public string Make { get; set; } = "Generice manufacturer";
        public string Model { get; set; } = "Generic model";
        public string Year { get; set; } = "No year";  

        public abstract void DriveAbstract();  //stubbed out method (no body/scope), abstrct will not have implementation, have to overwrite


        public virtual void DriveVirtual()    // method virtual means can but does not have to override if want to, but has a base/scope.
        {
            Console.WriteLine("I drive this vehicle sparingly.");
        }

    }
}
