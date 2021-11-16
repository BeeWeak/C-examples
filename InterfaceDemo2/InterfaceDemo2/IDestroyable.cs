using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceDemo2
{
    interface IDestroyable
    {
        //property to store audio file of the destruction sound

        string DestructionSound { get; set; }

        //method to destroy an object
        void Destroy()
        {

        }
    }
}
