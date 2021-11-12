using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesComputron
{
    class PasswordManager : IDisplayable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display()
        {
            
            if(Hidden == false)
            {
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine(Hidden);
                
                
            }
        }
    }

}
