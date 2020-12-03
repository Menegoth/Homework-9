using System;
using System.Collections.Generic;
using System.Text;

namespace Homework9 {
    class Truck : Vehicle {

        //instance variables
        public double LoadCapacity { get; set; }
        public int TowingCapacity { get; set; }

        //constructors
        public Truck() { }
        public Truck(double loadCapacity, int towingCapacity, string manufacturer, int cylinders, Person owner) {
            LoadCapacity = loadCapacity;
            TowingCapacity = towingCapacity;
            Manufacturer = manufacturer;
            Cylinders = cylinders;
            Owner = owner;
        }
        public Truck(Truck obj) {
            LoadCapacity = obj.LoadCapacity;
            TowingCapacity = obj.TowingCapacity;
            Manufacturer = obj.Manufacturer;
            Cylinders = obj.Cylinders;
            Owner = obj.Owner;
        }

        /// <summary>
        /// Returns object as string
        /// </summary>
        /// <returns>all instance variables</returns>
        public override string ToString() {
            return "Manufacturer: " + Manufacturer + "\nCylinders: " + Cylinders + "\nOwner: " + Owner + "\nLoad Capacity: " + LoadCapacity + "\nTowing Capacity: " + TowingCapacity;
        }

        /// <summary>
        /// Compares two truck objects
        /// </summary>
        /// <param name="obj">Other truck object</param>
        /// <returns>true if equal</returns>
        public bool Equals(Truck obj) {
            return Manufacturer == obj.Manufacturer && Cylinders == obj.Cylinders && Owner == obj.Owner && LoadCapacity == obj.LoadCapacity && TowingCapacity == obj.TowingCapacity;
        }

    }
}
