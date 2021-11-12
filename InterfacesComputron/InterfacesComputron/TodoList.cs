using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesComputron
{
    class TodoList : IDisplayable
    {
        public string[] Todos
        { get; private set; }

        private int nextOpenIndex;

        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }

        public void Add(string todo)
        {
            Todos[nextOpenIndex] = todo;
            nextOpenIndex++;
        }
        public void Display()
        {
            Console.WriteLine(Todos);
        }
    }
}
