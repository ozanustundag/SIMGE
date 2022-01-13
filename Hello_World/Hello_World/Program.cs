using System;
using System.Linq;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] grades = new int[2, 3]
            {
                {2,4,5 },
                {4,84,95}
            };
            int[,] grads2 =
            {
                {4,5,5,5 },
                {4,8,9,6 },
                {1,4,6,8 }
            };
            int[][] grads3 =
            {
                new int[] {4,7,8},
                new int[] { 1},
                new int[] {2,3}
            };

            Console.WriteLine(grads3.Length);
            Console.WriteLine(grads3[1].Length);

            for (int i = 0; i < grads3.Length; i++)
            {
                for (int k = 0; k < grads3[i].Length; k++)
                {
                    Console.Write(grads3[i][k] +" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(grades.GetLength(0));
            Console.WriteLine(grades.GetLength(1));

            for (int i = 0; i < grades.GetLength(0); i++)
            {
                for (int k = 0; k < grades.GetLength(1); k++)
                {
                    Console.Write(grades[i,k] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}   

