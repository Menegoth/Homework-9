using System;

namespace Homework9 {
    class Program {
        static void Main(string[] args) {

            Person john = new Person("John");
            Person james = new Person("James");
            Console.WriteLine(john);
            Console.WriteLine(james);
            Console.WriteLine(john.Equals(james));

            Vehicle car1 = new Vehicle("Toyota", 2, john);
            Vehicle car2 = new Vehicle();
            car2.Manufacturer = "Toytota";
            car2.Cylinders = 2;
            car2.Owner = james;
            Console.WriteLine(car1);
            Console.WriteLine(car2);
            Console.WriteLine(car1.Equals(car2));

            Truck truck1 = new Truck(112.3, 12, "Mercedes", 7, john);
            Truck truck2 = new Truck();
            truck2.LoadCapacity = 1123.5;
            truck2.TowingCapacity = 8;
            truck2.Manufacturer = "Mercedes";
            truck2.Cylinders = 1;
            truck2.Owner = james;
            Console.WriteLine(truck1);
            Console.WriteLine(truck2);
            Console.WriteLine(truck1.Equals(truck2));


        }
    }
}
