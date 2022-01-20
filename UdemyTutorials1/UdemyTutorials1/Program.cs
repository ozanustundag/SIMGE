using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ref types and value types

            int a = 5;
            int b = a;
            Console.WriteLine(a);
            a++;
            Console.WriteLine(b);

            string[] c = { "Ozan", "kerem" };
            string[] d = c;
            c[0] ="aslı";
            Console.WriteLine(c[0]);
            
            Console.WriteLine(d[0]);

        }
    }
}
