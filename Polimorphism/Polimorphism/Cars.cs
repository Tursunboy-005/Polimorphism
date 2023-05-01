using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal  class Car
    {
        public string Model { get; set; }
        public decimal Price { get; set; }

        public Car(decimal price, string model)
        {
            Model = model;
            Price = price;
        }
        public virtual void Drive()
        {
            Console.WriteLine($"Car  is driving...");
        }
        public virtual void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }
    class ExpensiveCar : Car
    {
        public double Battery { get; set; }

        public ExpensiveCar(decimal price, string model, double battery)
           : base(price, model)
        {
            Battery = battery;
        }
        public override void Drive()
        {
            Console.WriteLine("ExpensiveCar is running");
        }
    }
    class Tesla : ExpensiveCar
    {
        public Tesla(decimal price, string model, double battery)
               : base(price, model, battery)
        {
        }
    }
    class TeslaY : Tesla
    {
        public int NumberY { get; set; }
        public TeslaY(int numberY, decimal price, string model, double battery)
            : base(price, model, battery)
        {
            NumberY = numberY;
        }
        public override void Drive()
        {
            Console.WriteLine("TeslaY is running");
        }
        public override void Stop()
        {
            Console.WriteLine("TeslaY is stopping");
        }
    }
    class TeslaX : Tesla
    {
        public int NumberX { get; set; }
        public TeslaX(int numberX, decimal price, string model, double battery)
            : base(price, model, battery)
        {
            NumberX = numberX;
        }
        public override void Drive()
        {
            Console.WriteLine("Teslax is running");
        }
        public override void Stop()
        {
            Console.WriteLine("TeslaX is stopping");
        }
    }
}
