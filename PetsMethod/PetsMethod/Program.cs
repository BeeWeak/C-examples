using System;

namespace PetsMethod
{
    class Program
    {
        
        static void NamePets(string name1 = "", string name2 = "")
        {
            Console.WriteLine("Your pets {0} and {1} will be joining your voyage across space!", name1, name2);
            
        }
        static void NamePets2(string name1, string name2, string name3)
        {
            Console.WriteLine("Your pets {0}, {1}, and {2} will be joining your voyage across space!",name1,name2,name3);
        }

        static void NamePets3()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }
        static void Main(string[] args)
        {
            NamePets("Harry", "James");
            NamePets2("Harry", "James", "Watson");
            NamePets();
            NamePets3();
        }
    }
}
