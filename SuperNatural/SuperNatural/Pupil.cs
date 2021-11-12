using System;
using System.Collections.Generic;
using System.Text;

namespace SuperNatural
{
    class Pupil
    {
        public string Title

        {
            get; protected set;
           
        }


        public Pupil(string title)
        {
            Title = title;
        }

        public Storm CastWindStorm()
        {
            Console.WriteLine("a weak wind storm was cast");
            Storm Weakwindstorm = new Storm("Somebody", false, "Wind");
            return Weakwindstorm;
        }
    }
}
