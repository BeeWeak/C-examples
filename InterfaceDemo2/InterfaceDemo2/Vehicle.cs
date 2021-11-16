using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo2
{
    class Vehicle
    {
        //set speed of Vehicle
        public float Speed { get; set; }
        //set color of Vehicle
        public string Color { get; set; }


        //constructor
        public Vehicle()
        {
            Speed = 120f;
            Color = "White";
        }

        //another constructor
        public Vehicle(float speed, string color)
        {
            Speed = speed;
            Color = color;
        }
    }
}
