using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;


            for( i = 0; i < 10; i++)
            {
                Console.WriteLine("Test");
            }


            for(i = 0; i < 16; i++)
            {
                if(i == 12)
                {
                    break;
                }
            }

            for(i = 0; i < 16; i++)
            {
                if(i % 2 == 1)
                {
                    continue;
                }

                Console.WriteLine(i);
            }
            
        }
    }
}
