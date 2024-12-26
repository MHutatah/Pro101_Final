using System;

namespace ConsoleApp
{
    class Vehicle
    {
        public string name {get; set;}
        private float speed {get; set;}
        public static int totalVehicles = 0;

        public Vehicle(string name, float speed)
        {
            this.name = name;
            this.speed = speed;
            totalVehicles++;
        }

        public virtual void Start()
        {
            Console.WriteLine("Vehicle is starting!");
        }

        public virtual void Accelerate(int increment)
        {
            this.speed += increment;
            Console.WriteLine($"Vehicle is accelerating from {this.speed - increment} km/h to {this.speed} km/h");
        }

        public float GetSpeed()
        {
            return this.speed;
        }
    }
}