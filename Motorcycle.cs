using System;

namespace ConsoleApp
{
    class Motorcycle : Vehicle
    {
        private float Speed {get; set;}
        public static int totalMotorcycles = 0;

        public Motorcycle(string name, float speed) : base(name, speed)
        {
            this.name = name;
            this.Speed = speed;
            totalMotorcycles++;
        }
        public override void Start(){
            Console.WriteLine("The motorcycle roars to life!");
        }

        public override void Accelerate(int increment)
        {
            base.Accelerate(increment*2);
        }
    }
}