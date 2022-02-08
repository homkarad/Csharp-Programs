using System;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {

            // declare a jagged array
            int[][] jaggedArray = new int[2][];

            // set size of Jagged Array Elements
            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[2];

            // initialize the first array
            jaggedArray[0][0] = 1;
            jaggedArray[0][1] = 3;
            jaggedArray[0][2] = 5;

            // initialize the second array
            jaggedArray[1][0] = 2;
            jaggedArray[1][1] = 2;

            // outer for loop
            for (int i = 0; i < jaggedArray.Length; i++)
            {

                Console.Write("Element " + i + ": ");
                // inner for loop
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
