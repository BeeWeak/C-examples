using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo2
{
    class Furniture
    {
        //setting properties of furniture class
        public string Color { get; set; }
        public string Material { get; set; }

        //constructor
        public Furniture()
        {
            Color = "White";
            Material = "Wood";

        }

        //constructor
        public Furniture(string color, string material)
        {
            Color = color;
            Material = material;
        }
    }
}
