using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo2
{

    //subclass Car extends to Vehicle
    class Car : Vehicle , IDestroyable
    {
        //implementing interface property
        public string DestructionSound { get; set; }


        public List<IDestroyable> DestroyablesNearby;



        //constructor
        public Car(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;

            DestructionSound = "CarExplosionSound.mp3";
            DestroyablesNearby = new List<IDestroyable>();
        }
        //implement interface method
        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            foreach(IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
        
    }
}
