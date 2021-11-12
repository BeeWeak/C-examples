using System;

namespace SuperNatural
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Storm s = new Storm("harry", true,"wind");
            s.Announce();
            Pupil p = new Pupil("Houdini");
            p.CastWindStorm();

            Mage m = new Mage("Houdini2");
            m.CastWindStorm();
            m.CastRainStorm();
        }
    }
}
