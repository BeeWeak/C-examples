using System;

namespace methodsClass
{
    class Program
    {

        static void VisitPlanets()
        {
            Console.WriteLine("You visited many new planets...");
        }

        static void YourMethodName(string identity, int age)
        {
            Console.WriteLine(identity);
            Console.WriteLine(age);

            Console.WriteLine("{0} is {1} years old.", identity, age);
        }

        static void Main(string[] args)
        {
            VisitPlanets();
            YourMethodName("Harry", 20);

            
        }

    }
}
