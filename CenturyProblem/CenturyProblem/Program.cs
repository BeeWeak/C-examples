using System;

namespace CenturyProblem
{
    class Program
    {
        static void Century(int year)
        {
            int value = ((year - 1) / 100) + 1;
            Console.WriteLine(value);     
        }
        static void Main(string[] args)
        {
            Century(1999);
            Century(2000);
            Century(2020);
        }
    }
}
