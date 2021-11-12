using System;

namespace ifStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 4;
            int c = 5;
            bool b = a == 4;

            if (b)
            {
                Console.WriteLine("Its true!");
            }


            if (a == 4)
            {
                Console.WriteLine("So it is a 4");
            }


            if (a == c)
            {
                //do something cool
            }
            else
            {
                //do this
            }


            if (a == c)
                Console.WriteLine("another line");
            else
                Console.WriteLine("Hello world");

            int guess = 500;

            if (guess == 500)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
