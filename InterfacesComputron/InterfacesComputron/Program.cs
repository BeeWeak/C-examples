using System;

namespace InterfacesComputron
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordManager pm = new PasswordManager("password",true);
            pm.Display();

            TodoList tdl = new TodoList();
            tdl.Display();
         
        }
    }
}
