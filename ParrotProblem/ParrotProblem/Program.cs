using System;

namespace ParrotProblem
{
    class Program
    {
        static void Parrot(bool talking, int hour)
        {
            if (hour < 7 & talking == true || hour > 20 & talking == true)
            {
                Console.WriteLine("We are in trouble");
            }
            else
            {
                Console.WriteLine("Reasonable hour");
            }
        }
        
        static void Main(string[] args)
        {
            Parrot(true, 4);
            Parrot(true, 8);
            Parrot(true, 21);
            Parrot(false, 4);
            Parrot(false, 8);
            Parrot(false, 21);

        }
    }
}
