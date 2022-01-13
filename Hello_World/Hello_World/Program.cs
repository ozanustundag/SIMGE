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

             List<int> grades = new List<int>() {5,10 };
           
            grades.Add(50);
            grades.Insert(2, 14);
            //grades.Clear();
            grades.Remove(2);
            Console.WriteLine(grades[2]);
            Console.WriteLine(grades[3]);
             
        }
    }
}   

