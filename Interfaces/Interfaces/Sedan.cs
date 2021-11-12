using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{

    class Sedan : Vehicle, Iautomobile

    {
        public Sedan(double speed) : base(speed)
        {
            Wheels = 4;
        }

        public override string Describe()
        {
            return $"This Sedan is moving on {Wheels} wheels at {Speed} km/h, with license plate {LicensePlate}";
        }
    }
    
    
}
