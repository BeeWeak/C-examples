using System;

namespace FarmLegProblem
{
    class Program
    {
        static void Legs(int chickens, int cows, int pigs)
        {
            int chickenlegs = chickens * 2;
            int cowlegs = cows * 4;
            int piglegs = pigs * 4;
            int totallegs = chickenlegs + cowlegs + piglegs;
            Console.WriteLine("There are {0} and {1} legs and a total of {2}", chickens, chickenlegs,totallegs);
            Console.WriteLine("There are {0} and {1} legs and a total of {2}", cows, cowlegs, totallegs);
            Console.WriteLine("There are {0} and {1} legs and a total of {2}", pigs, piglegs, totallegs);

        }
        static void Main(string[] args)
        {
            Legs(2, 3, 5);
            Legs(1, 2, 3);
            Legs(5, 2, 8);
            
        }
    }
}
