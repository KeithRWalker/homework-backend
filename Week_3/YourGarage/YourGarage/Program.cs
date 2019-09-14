using System;
using System.Collections.Generic;
using YourGarage.Classes;
using YourGarage.Classes.Cars;

namespace YourGarage
{
    class Program
    {
        public static void Main()
        {
            // Build a collection of all vehicles that fly
            var planes = new List<Aircraft>();
            planes.Add(new Aircraft());
            planes.Add(new Aircraft());
            planes.Add(new Aircraft());
            planes.Add(new Aircraft());

            // With a single `foreach`, have each vehicle Fly()
            foreach (var plane in planes)
            {
                plane.Drive(10);
            }

            // Build a collection of all vehicles that operate on roads
            var cars = new List<Car>();
            cars.Add(new ElectricCar("black"));
            cars.Add(new SUV("White"));
            cars.Add(new Car());

            // With a single `foreach`, have each road vehicle Drive()
            foreach (var car in cars)
            {
                car.Drive(10);
            }

            // Build a collection of all vehicles that operate on water
            var boats = new List<Watercraft>();
            boats.Add(new Watercraft("Green"));
            boats.Add(new Watercraft("Blue"));
            boats.Add(new Watercraft("Yellow"));
            boats.Add(new Watercraft("Orange"));
            // With a single `foreach`, have each water vehicle Drive()
            foreach (var boat in boats)
            {
                boat.Drive(10);
            }
        }
    }
}
