using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //nested foreach loop

            List<List<int>> studentGrades = new List<List<int>>() {
            new List<int> {5,10 },
            new List<int>{26,45,54},
            new List<int>{1},
            new List<int>{68,68,26}
            };
            foreach (List<int> grade in studentGrades)
            {
                foreach (int grades in grade)
                {
                    Console.WriteLine(grades + "\t");
                }
                Console.WriteLine();    
            }

            int[][] studentGrades2 = {
               new int[] {2,4},
                new int [] {3,4,6},
                new int [] {4,9,45 }
            };

            foreach (int[] grade in studentGrades2)
            {
                foreach (int grades in grade)
                {
                    Console.WriteLine(grades+" ");
                }
                Console.WriteLine();
            }
        }
    }
}   

