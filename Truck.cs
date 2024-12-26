using System;

namespace ConsoleApp
{
    class Truck : Vehicle
    {
        public float CargoCapacity {get; set;}
        private float Speed {get; set;}
        public static int totalTrucks = 0;

        public Truck(string name, float speed) : base(name, speed)
        {
            this.name = name;
            this.Speed = speed;
            totalTrucks++;
        }
        public override void Start(){
            Console.WriteLine("The truck's heavy engine rumbles as it starts!");

        }
    }
}