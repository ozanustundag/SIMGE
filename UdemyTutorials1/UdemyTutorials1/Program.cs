using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default Value Parameter

            Console.WriteLine(Sum());
        }
        static int Sum(int a =6,int b= 4)
        {
            return a + b;
        }
    }
}
