using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jagged_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            matrix[0] = new int[] { 1, 2, 4, 6 };
            matrix[1] = new int[] { 4, 5, 0 };
            matrix[2] = new int[] { 7, 8, 9 };


            int element = matrix[0][1];
            Console.WriteLine($"Task 2:Element={element}");

            Console.WriteLine("Task 2.2: Displaying the entire matrix");
            foreach (var row in matrix)
            {
                foreach (var num in row)
                {
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Matrix ine nested loop");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + " ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine("Task 3");
            matrix[1][2] = 15;
            Console.WriteLine("Task 4");
            object[][] objectMatrix = new object[2][]
            {
                new object[]{1,"jambu",1.12},
                new object[]{true,'i',4.2}

            };
            Console.WriteLine("Object Matrix:");
            for (int i = 0; i < objectMatrix.Length; i++)
            {
                for (int j = 0; j < objectMatrix[i].Length; j++)
                {
                    Console.WriteLine("Type: {0}, Value: {1}", objectMatrix[i][j].GetType().Name, objectMatrix[i][j]);
                }
                Console.WriteLine();
            }

        }
    }
}
