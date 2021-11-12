using System;

namespace StaticMembers
{
  class Program
  {
    static void Main(string[] args)
    {
      Forest f = new Forest("Congo", "Tropical");
      
      f.Grow();

      Console.WriteLine(Forest.TreeFacts);
      Console.WriteLine(Forest.ForestsCreated);

      Forest a = new Forest("Congo", "Desert");
      Forest b = new Forest("Tropical", "Desert");

      Console.WriteLine(Forest.ForestsCreated);
    }
  }
}
