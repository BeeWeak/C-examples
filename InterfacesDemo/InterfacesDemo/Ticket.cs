using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    class Ticket : IEquatable<Ticket>
    {
        //property to store duration of ticket hours

        public int DurationInHours { get; set; }

        //constructor
        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
