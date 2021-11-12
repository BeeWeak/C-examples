using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNatural
{
    class Mage : Pupil
    {
        public Mage(string title): base(title)
        {

        }

        public Storm CastRainStorm()
        {
            Console.WriteLine("A weak rain storm was cast");
            Storm Weakrainstorm = new Storm("Somebody", false, "Rain");
            return Weakrainstorm;
        }

        public Storm CastLightingStorm()
        {
            Storm Lightningstorm = new Storm("Somebody", true, "Lightning");
            return Lightningstorm;
        }
    }
}
