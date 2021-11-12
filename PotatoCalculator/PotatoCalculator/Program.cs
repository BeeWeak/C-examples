using System;
using System.Text.RegularExpressions;

namespace PotatoCalculator
{
    class Program
    {
        static void PotatoCalculator(string potato)
        {
            
            string pattern = @"\bm\S*e\b";
            Regex rg = new Regex(pattern);

            MatchCollection matching = rg.Matches(potato);

            for (int count = 0; count < matching.Count; count++)
            {
                Console.WriteLine(count);
            }

        }
        static void Main(string[] args)
        {
            PotatoCalculator("potato");
            PotatoCalculator("potato");
            PotatoCalculator("potato");
        }
    }
}


