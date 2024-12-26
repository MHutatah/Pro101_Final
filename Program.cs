using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = {
                new Car("Car", 100),
                new Truck("Truck", 80),
                new Motorcycle("Motorcycle", 120),
                new Car("Car", 60),
                new Truck("Truck", 30)
            };

            Random random = new Random();
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.Start();
                vehicle.Accelerate(random.Next(1, 100));
                Console.WriteLine($"{vehicle.name} is going {vehicle.GetSpeed()} km/h");
            }

            Console.WriteLine($"Total vehicles: {Vehicle.totalVehicles}, distributed as follows:");
            Console.WriteLine($"Total cars: {Car.totalCars}");
            Console.WriteLine($"Total trucks: {Truck.totalTrucks}");
            Console.WriteLine($"Total motorcycles: {Motorcycle.totalMotorcycles}");
        }
    }
}