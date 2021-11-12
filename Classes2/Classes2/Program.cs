using System;

namespace Classes2
{
    class myClass
    {
        public string test = "This works!";
    }

    class MainClass
    {
        public static void Main()
        {
            myClass myObject = new myClass();
            Console.WriteLine(myObject.test);
        }
    }
}
