using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        { 
            Sedan s = new Sedan(60);
            Console.WriteLine("Sedan with license plate {0} and {1}", s.LicensePlate, s.Wheels);
            s.SpeedUp();
            Console.WriteLine("Sedan's speed: {0}", s.Speed);

            Truck t = new Truck(60,5);
            Console.WriteLine("Truck with license plate {0} and {1}", t.LicensePlate, t.Wheels);
            t.SpeedUp();
            Console.WriteLine("Truck's speed: {0}", t.Speed);

            Truck t2 = new Truck(60, 500);
            Console.WriteLine("Truck with license plate {0} and {1}",t2.LicensePlate, t2.Wheels);
            t2.SpeedUp();
            Console.WriteLine("Truck's speed: {0}", t2.Speed);

            Bicycle b = new Bicycle(60);
            Console.WriteLine("Bicycle with {0} wheels", b.Wheels);
            b.SpeedUp();
            Console.WriteLine("Bicycle' speed: {0}", b.Speed);

            b.Describe();
            s.Describe();
            t2.Describe();
            t.Describe();
        }
    }
}
