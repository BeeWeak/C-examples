using System;

namespace DiceSimulatorClasses
{
    class Program
    {
        static void Main()
        {
            Random randomNumberGenerator;
            int randomNumber;
            randomNumberGenerator = new Random();

            randomNumber = randomNumberGenerator.Next(1, 7);
            Console.WriteLine("D6: " + randomNumber);

            randomNumber = randomNumberGenerator.Next(1, 7) + randomNumberGenerator.Next(1, 7);
            Console.WriteLine("2D6: " + randomNumber);

            randomNumber = randomNumberGenerator.Next(1, 7) + randomNumberGenerator.Next(1, 7) + randomNumberGenerator.Next(1, 7);
            Console.WriteLine("3D6: " + randomNumber);

            Console.ReadLine();
        }

        
    }
}
