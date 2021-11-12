using System;

namespace FarmProblem
{
    class Program
    {

        static void Append(string text)
        {
            Console.WriteLine("something " + text);
        }
        static void Main(string[] args)
        {
            Append("This is a test");
            Append("Bob jane");
            Append("is better than nothing");
        }
    }
}
