using System;

namespace WhileLoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int count = 0;
            while (num != 5)
            {
                Console.WriteLine("Please enter a number");
                num = Convert.ToInt32(Console.ReadLine());
                count = count + 1;
                if (count == 10)
                {
                    Console.WriteLine("Finished");
                    break;

                }
                else
                {
                    if (num == 5)
                    {
                        Console.WriteLine("Hey! you weren't supposed to enter 5");
                    }
                }
                
            }
            
        }
    }
}
