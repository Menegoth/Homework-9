using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9 {
    class Vehicle {

        //instance variables
        public string Manufacturer { get; set; }
        public int Cylinders { get; set; }
        public Person Owner { get; set; }

        //constructors
        public Vehicle () { }
        public Vehicle (string manufacturer, int cylinders, Person owner) {
            Manufacturer = manufacturer;
            Cylinders = cylinders;
            Owner = owner;
        }
        public Vehicle (Vehicle obj) {
            Manufacturer = obj.Manufacturer;
            Cylinders = obj.Cylinders;
            Owner = obj.Owner;
        }

        //methods
        /// <summary>
        /// Returns object as string
        /// </summary>
        /// <returns>all instance variables</returns>
        public override string ToString() {
            return "Manufacturer: " + Manufacturer + "\nCylinders: " + Cylinders + "\nOwner: " + Owner;
        }

        /// <summary>
        /// Compares two vehicle objects
        /// </summary>
        /// <param name="obj">Other vehicle object</param>
        /// <returns>true if equal</returns>
        public bool Equals(Vehicle obj) {
            return Manufacturer == obj.Manufacturer && Cylinders == obj.Cylinders && Owner == obj.Owner;
        }

    }
}
