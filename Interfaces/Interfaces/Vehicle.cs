using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    abstract class Vehicle
    {
        public string LicensePlate { get; protected set; }
        public double Speed { get; protected set; }
        public int Wheels { get; protected set; }
        public void Honk()
        {
            Console.WriteLine("Honk.");
        }

        public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = "abc";
        }
        public virtual void SpeedUp()
        {
            Speed += 5;

        }
        public virtual void SlowDown()
        {
            Speed -= 5;

        }

        public virtual string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}";
        }


    }
}
