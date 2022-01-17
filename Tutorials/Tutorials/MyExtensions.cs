using System;
using System.Collections;
using System.Collections.Generic;

namespace Tutorials
{
    public static class MyExtensions
    {

        public static void DisplayASMInfo(this object obj)
        {
            Console.WriteLine("heloooooo");

        }
        public static int Squareee(this int x)
        {
           return x*x;
        }

        public static void ShowList(this IEnumerable iterator)
        {
            foreach (var item in iterator)
            {
                Console.WriteLine(item);
            }
        }

    }
}
