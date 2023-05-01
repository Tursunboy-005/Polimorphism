using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TeslaX teslax = new TeslaX(1, 2, "teslax", 80);
            //teslax.Drive();
            //Console.WriteLine();
            //Tesla tesla = new Tesla(1, "tesla", 70);
            //tesla.Drive();
            //Console.WriteLine();
            //TeslaY teslay = new TeslaY(1, 20000, "teslay", 100);
            //teslay.Drive();

            Console.WriteLine("------------------------------------");

            Car car = new Car(1,"model");
            car.Drive();
            car.Stop();
            Console.WriteLine();
            //Car tesla1 = new Tesla(1,"Tesla",100);
            //tesla1.Drive();
            //tesla1.Stop();
            Console.WriteLine();
            car = new TeslaX(1,12000,"teslax",80);
            car.Drive();
            car.Stop();
            Console.WriteLine();
            car = new ExpensiveCar(1, "expensivecar", 70);
            car.Drive();
            car.Stop();
            Console.WriteLine();
            car = new TeslaY(1, 12000, "teslay", 50);
            car.Drive();
            car.Stop();


            Console.ReadLine();
        }
    }
}
