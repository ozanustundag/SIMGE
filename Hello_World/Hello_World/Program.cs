using System;
using System.Linq;

namespace Hello_World 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            //int[] grades = { 900, 54, 5464, 5454 };
            //int[] students = new int[20];
            //Console.WriteLine(grades[1] + " " + students[0]);

            //int size = Convert.ToInt32(Console.ReadLine());
            //int[] grades = new int[size];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    grades[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.WriteLine(grades[i]);
            //}

            //searching array

            int[] grades = { 20, 45, 65, 646 };
            int[] grades2 = { 20, 45, 65, 646 };
            Console.WriteLine(Array.IndexOf(grades, 45));
            //array sort
          //  Array.Sort(grades);
          //  Array.Reverse(grades);
            for (int i = 0; i < grades.Length; i++)
            {
                Console.WriteLine(grades[i]);
            }

            if (Enumerable.SequenceEqual(grades,grades2))
            {
                Console.WriteLine("equal");
            }
        }
    }
}
