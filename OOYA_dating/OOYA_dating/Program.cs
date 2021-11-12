using System;

namespace OOYA_dating
{
    class Program
    {
        static void Main(string[] args)
        {

            Profile sam = new Profile("Sam Drakkila", 30, "New York", "USA", "he/him");
            //Console.WriteLine("Hello world");
            sam.ViewProfile();

            //converted string s into array
            //passed new array into SetHobbies method.
            string s = Console.ReadLine();
            string[] hobbys = s.Split(' ');

            
            sam.SetHobbies(hobbys);
            sam.ViewProfile();
        }
    }  
}
