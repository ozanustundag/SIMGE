using System;
using System.Linq;
using System.Collections.Generic;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists

            List<int> grades = new List<int>() { 5, 10, 26, 45, 54, 68, 68,26 };

            foreach (int grade in grades.ToArray())
            {
                Console.WriteLine(grade);
            }
//-------------------------------------------
            //for (int i = 0; i < grades.Count; i++)
            //{
            //    grades[i] *= 2;
            //   Console.WriteLine( grades[i]);
            //}
//-------------------------------------------
            //List<int> grades2 = new List<int>() { 5, 10, 26, 45, 54, 68, 68, 26 };
            //if (grades.SequenceEqual(grades2))
            //{
            //    Console.WriteLine("Equal");
           
            //}
// ------------------------------------------
            //if (grades.Contains(5))
            //{
            //    Console.WriteLine("found");
            //}
//-------------------------------------------
            //if (grades.IndexOf(23) == -1)
            //{
            //    Console.WriteLine("true");
            //}
//-------------------------------------------
            //if (grades.LastIndexOf(26)==7)
            //{
            //    Console.WriteLine("true2");
            //}
        }
    }
}   

