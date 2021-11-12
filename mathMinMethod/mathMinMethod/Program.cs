using System;

namespace mathMinMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int integer = Math.Min(3, 5);
            Console.WriteLine(integer);

            string msg = "This is a string";
            Console.WriteLine("{0}", msg.Substring(0,1));

            string designer = "Anders Hejlsberg";

            var indexOfSpace = designer.IndexOf(" ");

            string secondName = designer.Substring(indexOfSpace);
            Console.WriteLine(secondName);

        }
    }
}
