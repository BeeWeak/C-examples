using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNatural
{
    class Archmage : Mage
    {
        public Archmage(string title) : base(title)
        {

        }

        public Storm CastWindStorm()
        {
            Console.WriteLine("A wind storm was cast");
            Storm Windstorm = new Storm("Somebody", true, "wind");
            return Windstorm;
        }
    }
}
