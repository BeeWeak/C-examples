using System;

namespace ForestClasses3
{
    class Forest
    {
        

        public Forest(string name, string biome)
        {
            this.Name = name;
            this.Biome = biome;
            Age = 0;
        }

        public Forest(string name) : this(name, "Unknown")
        {
            Console.WriteLine("Biome not specified. Value defaulted to Unknown");
        }

        public int Area
        {
            get;
            set;
        }

        public int IncreaseArea()
        {
            this.Area = Area;
            return Area;
        }


        private int trees;
        public int Trees
        {
            get { return trees; }
            set { trees = value; }
        }
        private string name;
        public string Name
        {
            get;
            set;
        }
        
        private int age;
        public int Age
        {
            get;
            set;
        }

        private string biome;
        public string Biome
        {
            get
            {
                return biome;
            }
            set
            {
                if (value != "Tropical" | value != "Temperate" | value != "Boreal")
                {
                    biome = "Unknown";
                }
                else { biome = value; }
            }
                
        }
        

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Forest f = new Forest("-forest","Desert");
            //f.Name = "wild";
            f.Trees = 50;
            f.Age = 4;
            f.Biome = "Desert";
            f.Area = 2;

            Console.WriteLine(f.Name);
            Console.WriteLine(f.Biome);
            //int result = f.IncreaseArea(2);
            //Console.WriteLine(result);
        }
    }
}
