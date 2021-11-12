using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int[] nums2 = new int[10];
            Console.WriteLine(nums.Length);

            int[] nums3 = new int[10];
            int firstNumber = nums3[0];
            int secondNumber = nums3[1];
            nums3[2] = 10;


            //multidimensional arrays

            int[,] matrix = new int[2, 2];
            matrix[0, 0] = 1;
            matrix[0, 1] = 2;
            matrix[1,0 ] = 3;
            matrix[1,1 ] = 4;

            int[,] predefinedMatrix = new int[2, 2] { { 1, 2 }, { 3, 4 } };


            string[] fruits = { "apple", "banana", "orange" };

        }
    }
}
