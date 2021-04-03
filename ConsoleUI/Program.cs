using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            List<Vehicle> vehicles = new List<Vehicle>();  // List<Vehicle>()  = a constructor


            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */ 
            Vehicle newCar = new Car() { Year = "2017", Make = "Jeep", Model = "Renegade", HasTrunk = false, HasGoodMileage = false }; // objects   
           // newCar.Year = 2017;               //     click cTRL + R+ R to change all of one filed (like all of newCar)
            //newCar.Make = "Jeep";
            //newCar.Model = "Renegade";
            //newCar.HasTrunk = true;
            //newCar.HasGoodMileage = true;

            Motorcycle newCycle = new Motorcycle();  //  Motorcycle() = a constructor  (polyphorphism - one ting many forms
            newCycle.Year = "2019";
            newCycle.Make = "Harley";
            newCycle.Model = "Low Rider";
            newCycle.HasSideCart = false;
            newCycle.HasSaddleBags = true;

            Vehicle newTruck = new Truck()
            {
                Year = "2030",
                Make = "Tesla",
                Model = "Cybertruck",
                HasBallAndHitch = false
            };

            Vehicle newCopter = new Car()
            {
               Year = "2015",
               Make = "Gimbal",
                Model = "Dynax 5"
            };

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            vehicles.Add(newCar);
            vehicles.Add(newCycle);
            vehicles.Add(newTruck);
            vehicles.Add(newCopter);

            foreach (var veh in vehicles)
            {
                Console.WriteLine($"Year: {veh.Year}, Make: {veh.Make}, Model: {veh.Model}");
                Console.WriteLine();
            }
            // Call each of the drive methods for one car and one motorcycle, have to call the method or will not output the CW
            newCar.DriveAbstract();
            Console.WriteLine();
            newCar.DriveVirtual();
            Console.WriteLine();
            newCycle.DriveAbstract();
            Console.WriteLine();
            newCycle.DriveVirtual();
            Console.WriteLine();
            newTruck.DriveAbstract();
            Console.WriteLine();
            newTruck.DriveVirtual();
            Console.WriteLine();
            newCopter.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
