using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
    
            #region Vehicles

            abstract class Vehicles {

            string Year;
            string Make;
            string Model;
            public abstract void DriveAbstract();
            public virtual void DriveVirtual() {

                Console.WriteLine("Wrooom");
            }

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

            public class Car : Vehicles {
                public bool HasTrunk;
                public Car(){

                }
                public override void DriveAbstract()
                {
                    Console.WriteLine("Driving Car Abstract!");
                }

            }

            public class Motorcycle : Vehicles
            {
                public bool HasSideCart;
                public Motorcycle()
                {
             
                }
                public override void DriveVirtual()
                {
                    Console.WriteLine("Driving Motorcycle Virtual!");
                }

                public override void DriveAbstract()
                {
                    Console.WriteLine("Driving Motorcycle Abstract!");
                }

            
            
            }
                
           
               
        static void Main(string[] args)
        {
                /*
                 * Todo follow all comments!! 
                 */
                // Create a list of Vehicle called vehicles

                /*
                 * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
                 * - new it up as one of each derived class
                 * Set the properties with object initializer syntax
                 */

                /*
                 * Add the 4 vehicles to the list
                 * Using a foreach loop iterate over each of the properties
                 */

                // Call each of the drive methods for one car and one motorcycle


                List<Vehicles> vehicles = new List<Vehicles>();
                Car c = new Car();

                c.Year = "2021";
                c.Model = "Camry";
                c.Make = "Toyota";
                Motorcycle m = new Motorcycle();
                m.Year = "2022";
                m.Model = "Woosh";
                m.Make = "Hyundai";
                Vehicles v = new Car();
                v.Year = "2023";
                v.Model = "Carr";
                v.Make = "CarrCompany";
                Vehicles v2 = new Motorcycle();
                v2.Year = "2022";
                v2.Model = "Swish";
                v2.Make = "Yamaha";
                vehicles.Add(c); 
                vehicles.Add(m);
                vehicles.Add(v);
                vehicles.Add(v2);
                foreach (var i in vehicles) 
                {
                    Console.WriteLine($"Printing information for {i.GetType().Name}:");
                    Console.WriteLine(i.Year);
                    Console.WriteLine(i.Model);
                    Console.WriteLine(i.Make);
                    i.DriveVirtual();
                    i.DriveAbstract();
                }
                Console.ReadLine();
                Console.WriteLine();
                
            }

            #endregion

        }
    }
}
