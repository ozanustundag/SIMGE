using System;
using System.Collections;
using System.Collections.Generic;

namespace UdemyTutorials1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ref and Out Keywords
            // ref ilk değer bekler out beklemez
            int a = 5;
            int b=1;
            Console.WriteLine(Sum(a, b));
            Console.WriteLine("After Normal Sum Method:");
            Console.WriteLine("a=" + a + "b=" + b);
            Console.WriteLine(Sum(ref a, out b));
            Console.WriteLine("After our/ref method:");
            Console.WriteLine("a=" + a + "b=" + b);


        }
      static int Sum(ref int number1,out int number2)
        {
            number1 = 1;
            number2 = 2;
            return number2 + number1;
        }
        static int Sum( int number1, int number2)
        {
            number1 = 1;
            number2 = 2;
            return number2 + number1;
        }

    }
}
