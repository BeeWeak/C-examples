using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class Truck : Vehicle, Iautomobile
    {
        public int Weight
        {
            get;
        }

        public Truck(double speed, int weight) : base(speed)
        {
            Weight = weight;
            if(weight > 400)
            {
                Wheels = 12;
            }
            else
            {
                Wheels = 8;
            }
        }

        public override string Describe()
        {
            return $"This Truck is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}";
        }

    }
}
