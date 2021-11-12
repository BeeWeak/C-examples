using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface Iautomobile
    {
        string LicensePlate { get; }
        double Speed { get; }

        int Wheels { get; }
        void Honk();

        void SpeedUp();

        void SlowDown();

    }
}
