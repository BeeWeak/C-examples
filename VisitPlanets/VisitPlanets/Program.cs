using System;

namespace VisitPlanets
{
    class Program
    {


        static void VisitPlanets(
            int numberOfPlanets = 0,
            string adjective = "brave",
            string name = "Cosmonaughts",
            double gForce = 4.2)

        {
            Console.WriteLine("You have visited {0} planets", numberOfPlanets);
            Console.WriteLine("Welcome back, {0} {1}.", adjective, name);
            Console.WriteLine("You visited {0} new planets...", numberOfPlanets);
            Console.WriteLine("...while experiencing a g-force of {0} g!", gForce);
        }
        static void Main(string[] args)
        {
            VisitPlanets();
            VisitPlanets(numberOfPlanets: 2);
            VisitPlanets(numberOfPlanets: 2, name: "Harry");
        }
    }
}
