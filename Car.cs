using System;

namespace ConsoleApp
{
    class Car : Vehicle
    {
        public float FuelEfficiency {get; set;}
        private float Speed {get; set;}
        public static int totalCars = 0;

        public Car(string name, float speed) : base(name, speed)
        {
            this.name = name;
            this.Speed = speed;
            totalCars++;
        }
        public override void Start(){
            Console.WriteLine("The car is starting with a smooth engine sound!");

        }
    }
}