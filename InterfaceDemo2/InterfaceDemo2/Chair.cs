using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo2
{
    //subclass of chair that extends to furniture
    class Chair : Furniture , IDestroyable
    {

        //implement interface property
        public string DestructionSound { get; set; }





        //constructor

        public Chair(string color, string material)
        {
            this.Color = color;
            this.Material = material;


            DestructionSound = "ChairDestructionSound.mp3";


        }

        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
