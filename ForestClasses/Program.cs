using System;

namespace BasicClasses
{
  class Program
  {
    static void Main(string[] args)
    {

        Forest f = new Forest();
        f.name = "dangerous";
        f.trees = 4;
        f.age = 445;
        f.biome = "what";
        
        Console.WriteLine(f.name);

    }
  }
}