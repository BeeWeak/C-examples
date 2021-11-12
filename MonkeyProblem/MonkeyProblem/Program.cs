using System;

namespace MonkeyProblem
{
    class Program
    {
        static void Monkey(string aSmile, string bSmile)
        {
            if (aSmile == "smiling" & bSmile == "smiling" || aSmile == "" & bSmile == "")
            {
                Console.WriteLine("run");
            }
            else
            {
                Console.WriteLine("Happy monkey");
            }
        }
        static void Main(string[] args)
        {
            Monkey("smiling", "smiling");
            Monkey("smiling", "");
            Monkey("", "smiling");
            Monkey("", "");
        }
    }
}
